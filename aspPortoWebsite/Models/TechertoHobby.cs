using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace aspPortoWebsite.Models
{
    public class TechertoHobby
    {
        public int TeacherID { get; set; }
        public int HobbyId { get; set; }
        public Teacher Teacher { get; set; }
        public Hobby Hobby { get; set; }
    }
}
