using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace aspPortoWebsite.Models
{
    public class Slider
    {
        public int ID { get; set; }
        [Required]
        public string TrendWord  { get; set; }
        [Required]

        public string DisCount { get; set; }
        [Required]
        [StringLength(15, ErrorMessage = "Prices is required")]
        public string ClothType { get; set; }
        [Required]
        public int Price { get; set; }
        public string Image { get; set; }
        [NotMapped]//menasi odurki database bunu nezere alma
        public IFormFile Photo { get; set; }
    }
    
}
