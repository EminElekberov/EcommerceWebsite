using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace aspPortoWebsite.Models
{
    public class MyBlogCollection
    {
        public int Id { get; set; }
        public string Image { get; set; }
        public string Date { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public IList<MyBlogCollectionReview> myBlogCollectionReviews { get; set; }
        [NotMapped]
        public IFormFile Photo { get; set; }
    }
}
