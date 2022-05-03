﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace aspPortoWebsite.Models
{
    public class ContactsForm
    {
        public int Id { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        public string MyOpinion { get; set; }
    }
}
