using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compentency_test_the_actual_one
{
    public class MovieStuff
    {
        string title;
        string director;
        string rating;

        public MovieStuff(string title, string director, string rating)
        {
            this.title = title;
            this.director = director;
            this.rating = rating;
        }

        public string Title { get => title; set => title = value; }
        public string Director { get => director; set => director = value; }
        public string Rating { get => rating; set => rating = value; }
    }
}
