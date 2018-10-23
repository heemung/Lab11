using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab11
{
    class Movie
    {
        public Movie()
        {
            AddingMovies();

        }
        public void AddingMovies()
        {
            Movies movieList = new Movies("The Maxtrix", "scifi");
            Movies movieList1 = new Movies("The Love Boat", "drama");
            Movies movieList2 = new Movies("Halloween", "horror");
            Movies movieList3 = new Movies("Finding Nemo", "animated");
            Movies movieList4 = new Movies("Star Wars", "scifi");
            Movies movieList5 = new Movies("Korea Show", "drama");
            Movies movieList6 = new Movies("The Village", "horror");
            Movies movieList7 = new Movies("Wreck it Ralph", "animated");
            Movies movieList8 = new Movies("Another Teen Movie", "drama");
            Movies movieList9 = new Movies("Big Mouth The Movie", "animated");
        }
    }
}
