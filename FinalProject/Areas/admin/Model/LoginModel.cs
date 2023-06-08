﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FinalProject.Areas.Model
{
    public class LoginModel
    {
        [Required]
        public string UserName { get; set; }
        public string Password { get; set; }
        public bool RememberMe { get; set;}
    }
}