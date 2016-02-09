﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Boxing.Api.Services.Models
{
    public class LoginModel
    {
        [Required(AllowEmptyStrings = false)]
        public string Username { get; set; }
        [Required(AllowEmptyStrings = false)]
        public string Password { get; set; }
    }
}