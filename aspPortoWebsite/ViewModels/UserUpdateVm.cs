using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace aspPortoWebsite.ViewModels
{
    public class UserUpdateVm
    {

        [Required]
        [StringLength(maximumLength: 50)]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [DataType(DataType.Password)]
        public string CurrentPassword { get; set; }
        [DataType(DataType.Password)]
        public string NewPassword { get; set; }
        [DataType(DataType.Password)]
        [Compare(nameof(NewPassword))]//bu yoxlayirki yuxarda yazilan  paswordla confim[aswordun eynidimi
        public string NewConfirmPassword { get; set; }
    }
}
