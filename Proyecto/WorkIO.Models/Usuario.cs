﻿using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WorkIO.Models
{
    public class Usuario:BaseEntity
    {
        [Required(ErrorMessage = "Usuario is required")]
        [MinLength(6, ErrorMessage ="User Name should at contain 4 character")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Password is required")]
        [MinLength(6, ErrorMessage = "Password should at contain 3 character")]
        public string Password { get; set; }


    }
}
