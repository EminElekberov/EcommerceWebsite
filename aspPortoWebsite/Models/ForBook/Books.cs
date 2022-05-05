using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace aspPortoWebsite.Models.ForBook
{
    public class Books
    {
        public int ID { get; set; }
        public string Image { get; set; }
        public string Name { get; set; }
        public int PresentPrice { get; set; }
        public int PastPrice { get; set; }
        public string Percent { get; set; }
        public string Sku { get; set; }
        public string Description { get; set; }
        public string SizeGuid { get; set; }
        public string AdditionalInformation { get; set; }
        public int ProductsCategoryId { get; set; }
        public DateTime? CreatedOn { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public ProductCategory productCategory { get; set; }
        public IList<BookGallery> bookGallery { get; set; }
        public IList<Review> Reviews { get; set; }

    }
}
