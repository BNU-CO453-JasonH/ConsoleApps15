﻿using System;
using System.ComponentModel.DataAnnotations;

namespace WebUI.Models
{
    public class Student
    {
        public int StudentID { get; set; }

        [StringLength(20), Required]
        public string Name { get; set; }

        [Range(0, 100)]
        public int Mark { get; set; }
    }
}
