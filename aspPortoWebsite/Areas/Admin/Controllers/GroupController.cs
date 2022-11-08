using aspPortoWebsite.Extension;
using aspPortoWebsite.Models;
using aspPortoWebsite.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace aspPortoWebsite.Areas.Admin.Controllers
{
    [Area("Admin")]
    //[Authorize(Roles = "Admin")]
    public class GroupController : Controller
    {
        private readonly PortoDbContext dbContext;

        public GroupController(PortoDbContext _dbContext)
        {
            dbContext = _dbContext;
        }

        public async Task<IActionResult> Index(int page=1)
        {
            int take = 1;
            //    var model = dbContext.Groups.OrderBy(x => x.Id).AsQueryable();
            //    int pageSize = 3;
            //    return View(await PaginatedList<Group>.CreateAsync(model.AsNoTracking(), id ?? 1,pageSize));

            GroupsAndPaginationVM model = new GroupsAndPaginationVM
            {
                Groups = await dbContext.Groups.Skip(take * (page - 1)).Take(take).ToListAsync(),
                Pagination = new PaginationModel(await dbContext.Groups.CountAsync(), take, page)
            };
            return View(model);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<JsonResult> Create(string name)
        {
            if (name == null)
            {
                return Json(new
                {
                    status = 400
                });
            }
            Group group = new Group
            {
                Fullname = name
            };

            await dbContext.Groups.AddAsync(group);
            await dbContext.SaveChangesAsync();

            return Json(new
            {
                status = 200
            });
        }
        public async Task<JsonResult> Edit(int? id)
        {
            if (id == null)
            {
                return Json(new
                {
                    status = 404
                });
            }

            var group = await dbContext.Groups.FindAsync(id);
            if (group == null)
            {
                return Json(new
                {
                    status = 404
                });
            }
            return Json(group);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<JsonResult> Edit(int id,string name)
        {
            var groups = await dbContext.Groups.FirstOrDefaultAsync(p => p.Id == id);
            if (groups == null)
            {
                return Json(new
                {
                    status = 404
                });
            }
            groups.Fullname =name;
            dbContext.Update(groups);
            await dbContext.SaveChangesAsync();
            return Json(new
            {
                status = 200
            });
        }
        [ValidateAntiForgeryToken]
        public async Task<JsonResult> Delete(int? id)
        {
            if (id == null) return Json(new
            {
                status = 404


            });
            Group grp = await dbContext.Groups.FindAsync(id);
            if (grp == null)
            {
                return Json(new
                {
                    status = 404
                });
            }

            dbContext.Groups.Remove(grp);
            await dbContext.SaveChangesAsync();
            return Json(new
            {
                status = 200
            });

        }

    }
}
