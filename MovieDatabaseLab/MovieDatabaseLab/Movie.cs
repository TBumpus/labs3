using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieDatabaseLab
{
    public class Movie
    {

        private string _Title; //{ get; set; }
        private string _Category; //{ get; set; }

        public Movie(string title, string category)
        {
            _Title = title;
            _Category = category;

        }

        public string GetTitle()
        {
            return _Title;
        }

        public string GetCategory()
        {
            return _Category;
        }


    }
}
