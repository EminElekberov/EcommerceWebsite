using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace aspPortoWebsite.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string Fullname { get; set; }
        public int GroupId { get; set; }


        public virtual Group Group { get; set; }
        public virtual StudentAdress Adress { get; set; }
    }
}
