﻿using aspPortoWebsite.Models;
using aspPortoWebsite.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace aspPortoWebsite.Controllers
{
    public class BlogController : Controller
    {
        private readonly PortoDbContext _dbContext;

        public BlogController(PortoDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IActionResult Index()
        {
            return View(_dbContext.MyBlogCollections.ToList());
        }
        public async Task<IActionResult> Details(int? id)
        {
            HomeVM homeVM = new HomeVM
            {
                myBlogCollections = _dbContext.MyBlogCollections.ToList(),
                BlogCollection=await _dbContext.MyBlogCollections.FindAsync(id),
                myBlogCollectionReviews=_dbContext.MyBlogCollectionReviews.Where(z=>z.MyBlogCollectionid==id).ToList()
            };
            #region
            //if (id == null)
            //{
            //    return NotFound();
            //}
            //var search = await _dbContext.MyBlogCollections.FindAsync(id);
            //if (search == null)
            //{
            //    return NotFound();
            //}
            #endregion
            return View(homeVM);
        }
        [HttpPost]
        public async Task<IActionResult> Details(MyBlogCollectionReview myBlogCollectionReview)
        {
            if (myBlogCollectionReview == null)
            {
                return NotFound();
            }
            _dbContext.MyBlogCollectionReviews.Add(new MyBlogCollectionReview { MyBlogCollectionid = myBlogCollectionReview.Id, Message = myBlogCollectionReview.Message, Email = myBlogCollectionReview.Email, Name = myBlogCollectionReview.Name});
            await _dbContext.SaveChangesAsync();
            return Redirect($"/blog/details/{myBlogCollectionReview.Id}");
        }
    }
}
