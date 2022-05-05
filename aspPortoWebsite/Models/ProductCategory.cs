using aspPortoWebsite.Models.ForBook;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace aspPortoWebsite.Models
{
    public class ProductCategory
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string className { get; set; }
        public List<Category> Categories { get; set; }
        public List<Books> Books { get; set; }
        public List<ShopByCategory> shopByCategories { get; set; }
    }
}
