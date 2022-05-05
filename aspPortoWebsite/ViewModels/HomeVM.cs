using aspPortoWebsite.Models;
using aspPortoWebsite.Models.ForBook;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace aspPortoWebsite.ViewModels
{
    public class HomeVM
    {
        public List<Slider> Sliders { get; set; }
        public List<Category> Categories { get; set; }
        public List<Books> Books { get; set; }
        public List<Review> listRewiew { get; set; }
        public Review Reviews { get; set; }
        public ContactsForm Contacts { get; set; }
        public List<HomeFooter> homeFooters { get; set; }
        public List<AskedQuestion> askedQuestions { get; set; }
    }
}
