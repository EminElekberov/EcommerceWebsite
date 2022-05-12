using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace aspPortoWebsite.Models
{
    public class Checkout
    {
        public int Id { get; set; }
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
    }
}
