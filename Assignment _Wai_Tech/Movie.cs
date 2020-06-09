using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment__Wai_Tech
{
   public class Movie
    {
        public string Title { get; set; }
        public int  Rating { get; set; }


        public Movie (string title, int rating)
        {
            Title = title;
            Rating = rating;
        }
    }
}
