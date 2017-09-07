﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MovieShop.Models
{
    public class Movie
    {
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }
        public Genre Genre { get; set; }

        [Required]
        public byte GenreId { get; set; }

        [Display(Name="Date Added")]
        public DateTime DateAdded { get; set; }
        [Required]
        [Display(Name="Release date")]
        public DateTime ReleaseDate { get; set; }

        [Display(Name="Number In Stock")]
        [Required]
        [Range(1,20)]
        public byte NumberInStock { get; set; }
        public byte NumberAvailable { get; set; }
    }
}