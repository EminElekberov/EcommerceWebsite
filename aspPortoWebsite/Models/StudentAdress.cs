﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace aspPortoWebsite.Models
{
    public class StudentAdress
    {
        public int Id { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public int StudentId { get; set; }
        public virtual Student Student { get; set; }
    }
}
