using aspPortoWebsite.Models.ForBook;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace aspPortoWebsite.Models
{
    public class Review
    {
        public int Id { get; set; }
        public string Name { get; set; }
        [EmailAddress]
        public string Email { get; set; }
        public string Message { get; set; }
        public DateTime Date { get; set; }
        public Books Books { get; set; }
        public int BooksId { get; set; }

    }
}
