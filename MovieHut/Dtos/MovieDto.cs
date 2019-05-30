﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MovieHut.Dtos
{
    public class MovieDto
    {
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        public GenreDto Genre { get; set; }

        public byte GenreId { get; set; }

        public DateTime DateAdded { get; set; }

        public DateTime ReleaseDate { get; set; }

        [Range(1,20)]
        public byte NumberInStock { get; set; }
    }
}