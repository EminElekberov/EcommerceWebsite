using aspPortoWebsite.Models.ForBook;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace aspPortoWebsite.Models
{
    public class Sales
    {
        public int Id { get; set; }
        public User User { get; set; }
        public string UserId { get; set; }
        public Books Books { get; set; }
        public int BooksId { get; set; }
        public int Count { get; set; }
        public double Price { get; set; }
        public DateTime date { get; set; } = DateTime.Now;

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string CompanyName { get; set; }
        [Required]
        public string Country { get; set; }
        [Required]
        public string SteetAddress { get; set; }
        [Required]
        public string Town { get; set; }
        [Required]
        public string PhoneNumber { get; set; }
        [Required]
        [EmailAddress]
        public string EmailAddress { get; set; }
        public string OrderInformation { get; set; }

    }
}
