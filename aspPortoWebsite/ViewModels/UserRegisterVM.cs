using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace aspPortoWebsite.ViewModels
{
    public class UserRegisterVM
    {
        [Required]
        [StringLength(maximumLength:50)]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [Required]
        [Compare(nameof(Password))]//bu yoxlayirki yuxarda yazilan  paswordla confim[aswordun eynidimi
        public string ConfirmPassword { get; set; }
        public bool Gender { get; set; }

    }
}
