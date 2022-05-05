using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace aspPortoWebsite.Models
{
    public class ShopByCategory
    {
        public int Id { get; set; }
        public string Image { get; set; }
        public ProductCategory ProductCategoryies { get; set; }
        public int ProductsCategoryId { get; set; }
        [NotMapped]
        public IFormFile Photo { get; set; }
     }
}
