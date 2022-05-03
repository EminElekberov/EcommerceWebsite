using aspPortoWebsite.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace aspPortoWebsite.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class QuestionController : Controller
    {
        private readonly PortoDbContext dbContext;
        public QuestionController(PortoDbContext _dbcontext)
        {
            dbContext = _dbcontext;
        }
        public IActionResult Index()
        {
            return View(dbContext.AskedQuestions.ToList());
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(AskedQuestion about)
        {
            if (!ModelState.IsValid)
            {
                return NotFound();
            }
            await dbContext.AskedQuestions.AddAsync(about);
            await dbContext.SaveChangesAsync();
            return Redirect("/Admin/Question/Index");
        }
        [HttpGet]
        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            AskedQuestion about = dbContext.AskedQuestions.Find(id);
            if (about == null)
            {
                return NotFound();
            }
            return View(about);
        }
        [HttpPost]
        public async Task<IActionResult> Edit(AskedQuestion about)
        {
            if (!ModelState.IsValid)
            {
                return View(about);
            }
            var chosedb = dbContext.AskedQuestions.Find(about.Id);
            chosedb.Answer = about.Answer;
            chosedb.Question = about.Question;
            await dbContext.SaveChangesAsync();
            return Redirect("/Admin/Question/Index");
        }

        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return Redirect("/NOtfound/ErrorPage");

            }
            var choose = await dbContext.AskedQuestions.FindAsync(id);
            if (choose == null)
            {
                return NotFound();

            }
            dbContext.AskedQuestions.Remove(choose);
            await dbContext.SaveChangesAsync();
            TempData["Success"] = "Slider silindi";
            return Redirect("/Admin/Question/Index");
        }
        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return Redirect("/NOtfound/ErrorPage");

            }
            var findId = dbContext.AskedQuestions.Find(id);
            if (findId == null)
            {
                return NotFound();

            }
            return View(findId);
        }
    }
}
