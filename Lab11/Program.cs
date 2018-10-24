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
                    Console.WriteLine("No movies exist in this category.");
                }
                else
                {
                    foreach(string s in danDoesntLike)
                    {
                    Console.WriteLine(s);
                    }
                }
            
/*
            foreach (Movies m in AddingMovies())
            {
                if(m.TheMovieCategory == userInputCat)
                {
                    Console.WriteLine(m.TheMovieName);
                }
            }
            */

           Console.ReadLine();
    
        }

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
                new Movies("Another Teen Movie", "drama"),
                new Movies("This Test Movie", "test")};

            return allMovies;
        }
    }
}
