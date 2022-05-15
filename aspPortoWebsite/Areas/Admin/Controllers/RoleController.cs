using aspPortoWebsite.Models;
using aspPortoWebsite.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace aspPortoWebsite.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin")]

    public class RoleController : Controller
    {
        private readonly PortoDbContext _portoDbContext;
        private readonly UserManager<User> _userManager;//bunun vasitesile gedib usrin mailini tapir,dogrulugunu yoxlayir.Check ve CRUD emeliyyatlari
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly SignInManager<User> _signInManager;

        public RoleController(PortoDbContext portoDbContext, UserManager<User> userManager, RoleManager<IdentityRole> roleManager, SignInManager<User> signInManager)
        {
            _portoDbContext = portoDbContext;
            _userManager = userManager;
            _roleManager = roleManager;
            _signInManager = signInManager;
        }
        public IActionResult Index()
        {
            return View(_roleManager.Roles);
        }
        [HttpGet]
        public async Task<IActionResult> ManageUserRoles(string id)
        {
            ViewBag.userid = id;
            var user = await _userManager.FindByIdAsync(id);
            if (user==null)
            {
                return NotFound();
            }
            var model = new List<UserRoleViewModel>();
            foreach (var item in _roleManager.Roles)
            {
                var userRoles = new UserRoleViewModel
                {
                    RoleId = item.Id,
                    RoleName=item.Name
                };
                if (await _userManager.IsInRoleAsync(user,item.Name))
                {
                    userRoles.IsSelected = true;
                }
                else
                {
                    userRoles.IsSelected = false;
                }
                model.Add(userRoles);
            }
            return View(model);
        }
        [HttpPost]
        public async Task<IActionResult> ManageUserRoles(List<UserRoleViewModel> models,string userId)
        {
            var user = await _userManager.FindByIdAsync(userId);
            if (user==null)
            {
                return NotFound();
            }
            var role = await _userManager.GetRolesAsync(user);
            var result = await _userManager.RemoveFromRolesAsync(user, role);
            if (!result.Succeeded)
            {
                return NotFound();
            }
           //result = await _userManager.AddToRoleAsync(user, models.Where(x => x.IsSelected).Select(y => y.RoleName));
            return Redirect("/Admin/Slider/Index");
        }
    
        public async Task<IActionResult> Update(string id)
        {
            IdentityRole identityRole =await _roleManager.FindByIdAsync(id);
            if (identityRole==null)
            {
                return NotFound();
            }
            return View(identityRole);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Update(IdentityRole identityRole)
        {
            IdentityRole identity = await _portoDbContext.Roles.FirstOrDefaultAsync(i=>i.Id==identityRole.Id);
            identity.Name = identityRole.Name;
            identity.NormalizedName = identityRole.Name.ToUpper();
            await _portoDbContext.SaveChangesAsync();
            return Redirect("/Admin/Role/Index");
        }
    }
}
