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
            Movies mRef = new Movies("temp", "temp");
            ArrayList allMovies = AddingMovies();

            Console.WriteLine("Please enter a category");
            // bool newbool = (mRef.TheMovieCategory)allMovies.Contains(userInputCat.);
            //bool newBool = allMovies.Contains(mRef.TheMovieCategory == userInputCat);
            userInputCat = Console.ReadLine();
            mRef.TheMovieCategory = userInputCat;
            bool newBool = allMovies.Contains(mRef.TheMovieCategory);

            if (allMovies.Contains(mRef.TheMovieCategory))
            {
                foreach (Movies m in allMovies)
                {
                    if (m.TheMovieCategory == userInputCat)
                    {
                        Console.WriteLine(m.TheMovieName);
                    }

                }
            }
            else
            {
                Console.WriteLine("not avaible");
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
                new Movies("Another Teen Movie", "drama")};

            return allMovies;
        }
    }
}
