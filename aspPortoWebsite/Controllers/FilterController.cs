using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace aspPortoWebsite.Controllers
{
    public class FilterController : Controller
    {
        public IActionResult Index(int rangePrimary)
        {
            if (rangePrimary == null)
            {
                return NotFound();
            }
            return View();
        }
    }
}
