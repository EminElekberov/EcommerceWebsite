using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace aspPortoWebsite.Models
{
    public class Hobby
    {
        [Key]
        public int HobbyId { get; set; }
        public string Name { get; set; }
        public IList<TechertoHobby> TechertoHobbies { get; set; }
    }
}
