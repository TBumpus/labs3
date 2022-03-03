using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieDatabaseLab
{
    internal class Movie
    {

        public string Title { get; set; }
        public string Category { get; set; }

        public Movie(string movieTitle, string movieCategory)
        {
            Title = movieTitle;
            Category = movieCategory;

        }

    }
}
