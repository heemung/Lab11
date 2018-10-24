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
            string userInputCat;
            Movies mRef = new Movies();
            ArrayList allMovies = AddingMovies();

            Console.WriteLine("Please enter a category");
            userInputCat = Console.ReadLine();

            ArrayList danDoesntLike = new ArrayList();
                foreach (Movies m in allMovies)
                {
                    if (m.TheMovieCategory == userInputCat)
                    {
                        danDoesntLike.Add(m.TheMovieName);
                    }

                }

                if(danDoesntLike.Count == 0)
                {
                    Console.WriteLine("That Category Doesn't Exist.\nPlease try again.");
                }
                else
                {
                Console.WriteLine("\nMovies in {0} category are:",userInputCat);
                danDoesntLike.Sort();
                    foreach(string s in danDoesntLike)
                    {
                    Console.WriteLine(s);
                    }
                }
           
           Console.ReadLine();
    
        }

        //added movies class objects at arraylist init
        public static ArrayList AddingMovies()
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
