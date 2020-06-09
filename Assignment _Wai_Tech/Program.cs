using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment__Wai_Tech
{
    class Program
    {
       
       
       
        public static void Main(string[] args)
        {
            List<string> list = new List<string>();

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Please enter a Movie");
                list.Add(Console.ReadLine()); // HERE !!
            }
        }

        public static void GeteMovieNames(List<string> movie, List<int> rating)
        {

            for(int i = 0; i<movie.Count; i++)
            {
                Console.WriteLine("{0}\t\t\t{1}", movie[i], rating[i]);

            }

        }
      




}

    
}
