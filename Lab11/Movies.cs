using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab11
{
    class Movies
    {
        public Movies(string movieName, string moviecategory)
        {

            TheMovieName = movieName;
            TheMovieCategory = moviecategory;
        }

        private int categoryCode;
        public int TheCatergoryCode
        {
            get
            {
                return categoryCode;
            }
            set
            {
                categoryCode = value;
            }
        }
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
