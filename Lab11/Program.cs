using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab11
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            ArrayList allMovies = new ArrayList{new Movies("The Maxtrix", "scifi"),
                new Movies("Big Mouth The Movie", "animated"),
                new Movies("Another Teen Movie", "drama"),
                new Movies("Wreck it Ralph", "animated"),
                new Movies("The Village", "horror"),
                new Movies("Star Wars", "scifi"),
                new Movies("Finding Nemo", "animated"),
                new Movies("Halloween", "horror"),
                new Movies("The Love Boat", "drama"),
                new Movies("Another Teen Movie", "drama")};
            Movies movieList = new Movies("The Maxtrix", "scifi");
            */


            /*
            foreach(Movies m in theseArrays)
            {
                m.TheCatergoryCode = theseArrays.IndexOf(m) + 1;
                Console.WriteLine(m.TheCatergoryCode);
            }*/
            string userInputCat;
            Console.WriteLine("Please enter a category");
            userInputCat = Console.ReadLine();

            foreach (Movies m in allMovies)
            {
                if(m.TheMovieCategory == userInputCat)
                {
                    Console.WriteLine(m.TheMovieName);
                }
            }
            

           Console.ReadLine();
    
        }
        public ArrayList AddingMovies()
        {
                ArrayList allMovies = new ArrayList{new Movies("The Maxtrix", "scifi"),
                new Movies("Big Mouth The Movie", "animated"),
                new Movies("Another Teen Movie", "drama"),
                new Movies("Wreck it Ralph", "animated"),
                new Movies("The Village", "horror"),
                new Movies("Star Wars", "scifi"),
                new Movies("Finding Nemo", "animated"),
                new Movies("Halloween", "horror"),
                new Movies("The Love Boat", "drama"),
                new Movies("Another Teen Movie", "drama")};

            return allMovies;
        }
    }
}
