using aspPortoWebsite.Models.ForBook;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace aspPortoWebsite.Models.ForCart
{
    public class Item
    {
        public Books Books { get; set; }
        public int Quantity { get; set; }
    }
}
