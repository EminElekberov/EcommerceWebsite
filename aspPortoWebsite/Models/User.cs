using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace aspPortoWebsite.Models
{
    public class User:IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public bool Gender { get; set; }
        public string Password { get; set; }
        [NotMapped]
        public List<string> RoleIds { get; set; }
        [NotMapped]
        public string RoleId { get; set; }
        [NotMapped]
        public string newRoleId { get; set; }

        public List<UserToProduct> UserToProducts { get; set; }
        public virtual ICollection<Checkout> Checkouts { get; set; }
        public virtual IList<Sales> Sales { get; set; }
    }
}
