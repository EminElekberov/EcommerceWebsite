using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace aspPortoWebsite.Models
{
    public class Category
    {
        public int ID { get; set; }

        [Required,StringLength(255)]
        public string Image { get; set; }

        [Required, StringLength(15)]
        public string Name { get; set; }
        public int PresentPrice { get; set; }
        public int PastPrice { get; set; }
        public string Percent { get; set; }
        public string Sku { get; set; }
        [Required]
        public string Description { get; set; }
        public string SizeGuid { get; set; }
        public string AdditionalInformation { get; set; }
        public ProductCategory ProductCategoryies { get; set; }
        public int ProductsCategoryId { get; set; }
        [NotMapped]//menasi odurki database bunu nezere alma
        public IFormFile Photo { get; set; }
        [NotMapped]
        public IFormFileCollection GalleryFiles { get; set; }
        public List<GalleryModel> Gallery { get; set; }
        [NotMapped]
        public int BooksID { get; set; }
        [NotMapped]
        public List<int> ColorId { get; set; }
        [NotMapped]
        public List<int> SizeId { get; set; }
    }
}
