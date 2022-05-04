using aspPortoWebsite.Extension;
using aspPortoWebsite.Models.ForBook;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace aspPortoWebsite.ViewModels
{
    public class ProductAndPaginationWm
    {
        public List<Books> Books { get; set; }
        public PaginationModel Pagination { get; set; }

    }
}
