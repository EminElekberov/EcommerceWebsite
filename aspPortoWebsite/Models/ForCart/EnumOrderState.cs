using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace aspPortoWebsite.Models.ForCart
{
    public enum EnumOrderState
    {
        [Display(Name = "Onay Bekleniyor")]
        Waiting,
        [Display(Name = "Tamamlandı")]
        Completed
    }
}
