using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab11
{
    class Movies
    {
        /*public Movies ()
        {

        }*/ //dont need anymore

        // constructor that inits two things on creation. Name and category.
        public Movies(string movieName, string moviecategory)
        {

            TheMovieName = movieName;
            TheMovieCategory = moviecategory;
        }

        //get sets name then assigns them to private.
        private string movieName;
        public string TheMovieName
        {
            get
            {
                return movieName;
            }
            set
            {
                movieName = value;
            }
        }

        //get sets catergory then assigns them to private.
        private string moviecategory;
        public string TheMovieCategory
        {
            get
            {
                return moviecategory;
            }
            set
            {
                moviecategory = value;
            }
        }
    }
}
