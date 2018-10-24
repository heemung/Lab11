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
            string userInputCat, yesOrNo;
            bool userContinue = true;

            //init a class continue
            Continue shouldContinue = new Continue();
            //made a method passing array list to new local array list.
            ArrayList allMovies = AddingMovies();

            Console.WriteLine("Welcome to the Movie List Application!" +
                "\nThere are 10 movies in this list.");

            //yes no loop
            while (userContinue)
            {
                Console.WriteLine("\nPlease enter a category");
                userInputCat = Console.ReadLine();

                //made array list to add movie names and list for abc sort later
                ArrayList danDoesntLike = new ArrayList();

                //clears the array from running the previous userContinue loop
                danDoesntLike.Clear();

                //each, array object checks the category to the user string
                //if matches it .adds the name of movie object to the other array.
                foreach (Movies m in allMovies)
                {
                    if (m.TheMovieCategory == userInputCat)
                    {
                        danDoesntLike.Add(m.TheMovieName);
                    }

                }
                //if the array has no objects we determin the category doesnt exist
                //else the array has objects so sort them and write them out
                if (danDoesntLike.Count == 0)
                {
                    Console.WriteLine("That Category Doesn't Exist.\nPlease try again.");
                }
                else
                {
                    Console.WriteLine("\nMovies in {0} category are:", userInputCat);
                    danDoesntLike.Sort();
                    foreach (string s in danDoesntLike)
                    {
                        Console.WriteLine(s);
                    }
                }

                //ask if user wants to continue from the continue class.
                //answerValid returns a bool which is assigned to the while loop above
                Console.WriteLine("\nDo you wish to continue? 'yes' / 'no'");
                yesOrNo = Console.ReadLine().ToLower();
                userContinue = shouldContinue.AnswerValid(yesOrNo);
            }
            Console.WriteLine("\nGoodbye");
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
