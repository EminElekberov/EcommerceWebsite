using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace aspPortoWebsite.Models
{
    public class MyBlogCollectionReview
    {
        public int Id { get; set; }
        public string Name { get; set; }
        [EmailAddress]
        public string Email { get; set; }
        public string Message { get; set; }
        public MyBlogCollection MyBlogCollection { get; set; }
        public int MyBlogCollectionid { get; set; }
    }
}
