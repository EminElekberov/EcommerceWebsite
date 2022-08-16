using aspPortoWebsite.Extension;
using aspPortoWebsite.Models;
using aspPortoWebsite.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace aspPortoWebsite.Controllers
{
    public class AccountController : Controller
    {
        private readonly PortoDbContext dbContext;
        private readonly UserManager<User> _userManager;
        private readonly SignInManager<User> _signInManager;
        private readonly IEmailService _emailService;
        public AccountController(PortoDbContext _dbContext,
            UserManager<User> userManager,
            SignInManager<User> signInManager,
            IEmailService emailService)
        {
            dbContext = _dbContext;
            _userManager = userManager;
            _signInManager = signInManager;
            _emailService = emailService;
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
            if (_userManager.FindByEmailAsync(register.Email).Result == null)
            {
                User user = new User
                {
                    UserName = register.Email,
                    Email=register.Email,
                    Password=register.Password,
                    FirstName=register.FirstName,
                    LastName=register.LastName
                };
                var result = await _userManager.CreateAsync(user, register.Password);
                if (result.Succeeded)
                {
                    _userManager.AddToRoleAsync(user, "User").Wait();
                    await _signInManager.SignInAsync(user, false);
                    return Redirect("/Account/Login");
                }
            }
            return View(register);

            #region
            //if (!ModelState.IsValid)
            //{
            //    return View(register);
            //}
            //if (_userManager.Users.Any(x=>x.NormalizedEmail==register.Email.ToUpper()))
            //{
            //    ModelState.AddModelError("Email", "User is exist");
            //    return View();
            //}
            //User user = new User
            //{
            //    Email=register.Email,
            //    UserName=register.Email,
            //    FirstName=register.FirstName,
            //    LastName=register.LastName
            //};
            //var result =await _userManager.CreateAsync(user, register.Password);
            //if (!result.Succeeded)
            //{
            //    foreach (var item in result.Errors)
            //    {
            //        ModelState.AddModelError("",item.Description);
            //        return View();
            //    }
            //}

            //string token = await _userManager.GenerateEmailConfirmationTokenAsync(user);
            //string callback = Url.Action("ConfirmEmail", "account", new { token, email = user.Email }, Request.Scheme);
            //string body = string.Empty;
            //using (StreamReader reader = new StreamReader("wwwroot/templates/forgetpasswod.html"))
            //{
            //    body = reader.ReadToEnd();
            //}
            //body = body.Replace("{{url}}", callback);
            //_emailService.Send(user.Email, "Reset Password", body);
            //await _userManager.AddToRoleAsync(user, "User");
            //await _signInManager.SignInAsync(user, true);
            //return RedirectToAction("Index","Home");
            #endregion
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(LoginVm loginVm)
        {
            if (ModelState.IsValid)
            {
                return NotFound();
            }
            var userName = await _userManager.FindByEmailAsync(loginVm.Email);
            var result = await _signInManager.PasswordSignInAsync(userName, loginVm.Password, false, false);
            if (result.Succeeded)
            {
                return Redirect($"/Home/Index/{userName.Email}");
            }
            return View(loginVm);

            #region
            //if (!ModelState.IsValid)
            //{
            //    return View(loginVm);
            //}
            //User user= await _userManager.FindByNameAsync(loginVm.Email);
            //if (user == null)
            //{
            //    ModelState.AddModelError("", "Email or password invalid");
            //    return View();
            //}
            //var result = await _signInManager.PasswordSignInAsync(user, loginVm.Password, false, false);
            //if (!result.Succeeded)
            //{
            //    ModelState.AddModelError("", "pasword is invalid");
            //    return View();
            //}
            //return RedirectToAction("Index", "Home");
            #endregion
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
        public IActionResult ForgetPassword()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> ForgetPassword(ForgetPasswordVM forgetVM)
        {
            User user =await _userManager.FindByEmailAsync(forgetVM.Email);
            if (user==null)
            {
                ModelState.AddModelError("", "email was not found");
                return View();
            }
            string token = await _userManager.GeneratePasswordResetTokenAsync(user);
            string callback = Url.Action("resetpassword", "account", new { token, email = user.Email }, Request.Scheme);
            string body = string.Empty;
            using (StreamReader reader=new StreamReader("wwwroot/templates/forgetpasswod.html"))
            {
                body = reader.ReadToEnd();
            }
            body = body.Replace("{{url}}", callback);
             _emailService.Send(user.Email, "Reset Password", body);
            return RedirectToAction("Login","Account");
        }

        public IActionResult ResetPassword(string token, string email)
        {
            ResetPasswordVM resetPasswordVM = new ResetPasswordVM
            {
                Token = token,
                Email = email
            };
            return View(resetPasswordVM);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> ResetPassword(ResetPasswordVM passwordVM)
        {
            if (!ModelState.IsValid) return View(passwordVM);
            User user = await _userManager.FindByEmailAsync(passwordVM.Email);
            var result = await _userManager.ResetPasswordAsync(user, passwordVM.Token, passwordVM.Password);
            if (!result.Succeeded)
            {
                foreach (var item in result.Errors)
                {
                    ModelState.AddModelError("", item.Description);
                }
                return View(passwordVM);
            }
            return RedirectToAction("Login", "Account");

        }

        [AllowAnonymous]
        public async Task<IActionResult> ConfirmEmail(string token, string email)
        {
            if (email == null || token == null)
            {
                return RedirectToAction("index", "home");
            }

            var user = await _userManager.FindByEmailAsync(email);

            if (user == null)
            {
                ViewBag.ErrorMessage = $"The User ID {email} is invalid";
                return View("NotFound");
            }

            var result = await _userManager.ConfirmEmailAsync(user, token);
            if (result.Succeeded)
            {
                return View();
            }

            ViewBag.ErrorTitle = "Email cannot be confirmed";
            return View("Error");
        }
    }
}
