using aspPortoWebsite.Models.ForBook;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace aspPortoWebsite.Models
{
    public class BooksToColor
    {
        [Key]
        public int ID { get; set; }
        public int ColorId { get; set; }
        public int BookId { get; set; }
        public virtual Books Books { get; set; }
        public virtual Color Color { get; set; }
    }
}
