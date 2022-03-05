using aspPortoWebsite.Models;
using aspPortoWebsite.ViewModels;
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
    }
}
