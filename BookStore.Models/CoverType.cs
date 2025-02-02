﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BookStore.Models
{
    public class CoverType
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(100)]
        [Display(Name="Cover Type")]
        public string Name { get; set; }
    }
}
