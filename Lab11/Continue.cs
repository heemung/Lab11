using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab11
{
    class Continue
    {
        //does not need anything in constructor, using property only.
        public Continue()
        {

        }

        private string stringCont;
        public string StringCont
        {
            get
            {
                return stringCont;
            }
            set
            {
                stringCont = value;
            }
        }

        // user continue loop and if statement , will return bool. Will only 
        //return if yes or no
        public bool AnswerValid(string s)
        {
            stringCont = s;
            while (true)
            {

                if (stringCont == "yes")
                {
                    return true;

                }
                else if (stringCont == "no")
                {
                    return false;
                }
                else
                {
                    Console.WriteLine("Please enter either 'yes' or 'no'\n");
                    StringCont = Console.ReadLine().ToLower();
                }
            }
        }
    }
}
