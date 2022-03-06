using aspPortoWebsite.Models;
using aspPortoWebsite.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace aspPortoWebsite.Controllers
{
    public class AccountController : Controller
    {
        private readonly PortoDbContext dbContext;
        private readonly UserManager<User> _userManager;
        private readonly SignInManager<User> _signInManager;
        public AccountController(PortoDbContext _dbContext, UserManager<User> userManager, SignInManager<User> signInManager)
        {
            dbContext = _dbContext;
            _userManager = userManager;
            _signInManager = signInManager;
        }
        public IActionResult Login()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]//menasi odurki yeni bir defe sorugu gondermek olsun
        public async Task<IActionResult> Register(UserRegisterVM register)
        {
            if (!ModelState.IsValid)
            {
                return View(register);
            }
            if (_userManager.Users.Any(x=>x.NormalizedEmail==register.Email.ToUpper()))
            {
                ModelState.AddModelError("Email", "User is exist");
                return View();
            }
            User user = new User
            {
                Email=register.Email,
                UserName=register.Email,
                FirstName=register.FirstName,
                LastName=register.LastName
            };
            var result =await _userManager.CreateAsync(user, register.Password);
            if (!result.Succeeded)
            {
                foreach (var item in result.Errors)
                {
                    ModelState.AddModelError("",item.Description);
                    return View();
                }
            }
            await _userManager.AddToRoleAsync(user, "User");
            await _signInManager.SignInAsync(user, true);
            return RedirectToAction("Index","Home");
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(LoginVm loginVm)
        {
            if (!ModelState.IsValid)
            {
                return View(loginVm);
            }
            User user= await _userManager.FindByNameAsync(loginVm.Email);
            if (user == null)
            {
                ModelState.AddModelError("", "Email or password invalid");
                return View();
            }
            var result = await _signInManager.PasswordSignInAsync(user, loginVm.Password, true, false);
            if (!result.Succeeded)
            {
                ModelState.AddModelError("", "pasword is invalid");
                return View();
            }
            return RedirectToAction("Index", "Home");
        }
        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("Index", "Home");
        }
        [Authorize(Roles ="User")]
        public async Task<IActionResult> Edit()
        {
            User user =  await _userManager.FindByNameAsync(User.Identity.Name);
            UserUpdateVm userUpdateVm = new UserUpdateVm
            {
                Email = user.Email,
                FirstName = user.FirstName,
                LastName = user.LastName
            };
            return View(userUpdateVm);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles ="User")]
        public async Task<IActionResult> Edit(UserUpdateVm userUpdateVm)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            User user = await _userManager.FindByNameAsync(User.Identity.Name);
            if (user.Email!=userUpdateVm.Email && _userManager.Users.Any(x=>x.NormalizedEmail==userUpdateVm.Email.ToUpper()))
            {
                ModelState.AddModelError("", "Username is already exists");
                return View();
            }
            if (!string.IsNullOrWhiteSpace(userUpdateVm.NewPassword))
            {
                if (userUpdateVm.NewPassword!=userUpdateVm.NewConfirmPassword)
                {
                    ModelState.AddModelError("", "Pasword with not matched confirm pass");
                    return View();
                }
                var result = await _userManager.ChangePasswordAsync(user, userUpdateVm.CurrentPassword, userUpdateVm.NewPassword);
                if (!result.Succeeded)
                {
                    foreach (var item in result.Errors)
                    {
                        ModelState.AddModelError("", item.Description);
                        return View();
                    }
                }
            }
            user.FirstName = userUpdateVm.FirstName;
            user.LastName = userUpdateVm.LastName;
            user.Email = userUpdateVm.Email;
            await _userManager.UpdateAsync(user);
            await _signInManager.SignInAsync(user, true);
            return RedirectToAction("Index", "Home");
        }
    }
}
