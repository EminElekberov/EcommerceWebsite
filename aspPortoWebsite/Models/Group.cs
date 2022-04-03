using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace aspPortoWebsite.Models
{
    public class Group
    {
        public int Id { get; set; }
        public string Fullname { get; set; }
        public virtual ICollection<Student> Students { get; set; }

    }
}
