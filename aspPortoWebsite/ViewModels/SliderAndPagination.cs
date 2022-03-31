using aspPortoWebsite.Extension;
using aspPortoWebsite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace aspPortoWebsite.ViewModels
{
    public class SliderAndPagination
    {
        public List<Slider> sliders { get; set; }
        public PaginationModel Pagination { get; set; }

    }
}
