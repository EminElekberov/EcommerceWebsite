using aspPortoWebsite.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace aspPortoWebsite.Areas.Admin.Controllers
{
    [Area("Admin")]

    public class AccountController : Controller
    {
        private readonly PortoDbContext _portoDbContext;
        //demdeli identity islemesi ucun asagidaki 3 esa klasdan isdifade edeceyik
        private readonly UserManager<User> _userManager;//bunun vasitesile gedib usrin mailini tapir,dogrulugunu yoxlayir.Check ve CRUD emeliyyatlari
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly SignInManager<User> _signInManager;

        public AccountController(PortoDbContext portoDbContext, UserManager<User> userManager, RoleManager<IdentityRole> roleManager, SignInManager<User> signInManager)
        {
            _portoDbContext = portoDbContext;
            _userManager = userManager;
            _roleManager = roleManager;
            _signInManager = signInManager;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Login()
        {
            User user = new User();
            return View(user);
        }
        [HttpPost]
        public async Task<IActionResult> Login(User user)
        {
            if (!ModelState.IsValid)
            {
                return NotFound();
            }
            var result = await _signInManager.PasswordSignInAsync(user.Email, user.PasswordHash, false, false);
            if (result.Succeeded)
            {
                return Redirect("/Admin/Slider/Index");
            }
            return View(user);
        }
        [HttpGet]

        public IActionResult Register()
        {

            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Register(Register register)
        {
            if (_userManager.FindByEmailAsync(register.Email).Result == null)
            {
                User identityUser = new User()
                {
                    UserName = register.Email
                };
                IdentityResult result = await _userManager.CreateAsync(identityUser, register.Password);
                if (result.Succeeded)
                {
                    _userManager.AddToRoleAsync(identityUser, "User").Wait();
                    await _signInManager.SignInAsync(identityUser, isPersistent: false);
                    return Redirect("/Admin/Account/Login");
                }
            }
            return View(register);
        }
        public async Task SeedRole()
        {
            if (!await _roleManager.RoleExistsAsync(roleName: "Admin"))
            {
                await _roleManager.CreateAsync(new IdentityRole(roleName: "Admin"));
            }
            if (!await _roleManager.RoleExistsAsync(roleName: "User"))
            {
                await _roleManager.CreateAsync(new IdentityRole(roleName: "User"));
            }
        }
        public async Task SeedAdmin()
        {
            if (_userManager.FindByEmailAsync("admin@gmail.com").Result == null)

            {
                User identityUser = new User()
                {
                    UserName = "admin",
                    Email = "admin@gmail.com"
                };
                IdentityResult result = await _userManager.CreateAsync(identityUser, "admin123!A");
                if (result.Succeeded)
                {
                    _userManager.AddToRoleAsync(identityUser, "Admin").Wait();
                    await _portoDbContext.SaveChangesAsync();
                    await _signInManager.SignInAsync(identityUser, true);
                }
            }
        }
    }
}
