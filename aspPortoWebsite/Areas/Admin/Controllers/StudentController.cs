using aspPortoWebsite.Models;
using aspPortoWebsite.ViewModels;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace aspPortoWebsite.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class StudentController : Controller
    {
        private readonly PortoDbContext portoDbContext;
        private readonly IWebHostEnvironment env;

        public StudentController(PortoDbContext _dbcontext, IWebHostEnvironment _env)
        {
            portoDbContext = _dbcontext;
            env = _env;
        }
        public IActionResult Index()
        {
            var group = portoDbContext.StudentAdresses.Include(x => x.Student).ThenInclude(x=>x.Group).ToList();
            return View(group);
        }
        [HttpGet]
        public IActionResult AddStudent()
        {
            ViewBag.Group = portoDbContext.Groups.ToList();
            return View();
        }
        [HttpPost]
        public IActionResult AddStudent(StudentVm model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            Student student = new Student
            {
                Fullname = model.Fullname,
                GroupId=model.GroupId
            };
            portoDbContext.Students.Add(student);
            portoDbContext.SaveChanges();
            StudentAdress studentAdress = new StudentAdress
            {
                City = model.City,
                Address=model.Address,
                Student=student
            };
            portoDbContext.StudentAdresses.Add(studentAdress);
            portoDbContext.SaveChanges();
            return Redirect("/Admin/Student/Index");
        }
        public IActionResult Edit(int? Id)
        {
            ViewBag.Group = portoDbContext.Groups.ToList();
            if (Id==null)
            {
                return NotFound();
            }
            Student student = portoDbContext.Students.Include(x => x.Group).Include(x => x.Adress).FirstOrDefault(x => x.Id == Id);
            if (student==null)
            {
                return NotFound();
            }
            return View(student);
        }
        //
        [HttpPost]
        public IActionResult Edit(Student student)
        {
            Student studentDb = portoDbContext.Students.Include(x => x.Group).Include(x => x.Adress).FirstOrDefault(x => x.Id == student.Id);
            if (studentDb==null)
            {
                return NotFound();
            }
            studentDb.Adress.Address = student.Adress.Address;
            studentDb.Fullname = student.Fullname;
            studentDb.GroupId = student.GroupId;
            studentDb.Adress.City = student.Adress.City;
            portoDbContext.SaveChanges();
            return Redirect("/Admin/Student/Index");
        }
    }
}
