using System;
using System.Collections.Generic;

namespace CreateMovieAPI.Models
{
    public partial class Movie
    {
        public int MovieId { get; set; }
        public string? Title { get; set; }
        public string? Genre { get; set; }
        public DateTime? ReleaseDate { get; set; }
    }
}
