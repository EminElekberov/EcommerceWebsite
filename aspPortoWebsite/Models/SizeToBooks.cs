using aspPortoWebsite.Models.ForBook;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace aspPortoWebsite.Models
{
    public class SizeToBooks
    {
        public int SizeId { get; set; }
        public int BooksId { get; set; }
        public virtual Size Size { get; set; }
        public virtual Books Books { get; set; }
    }
}
