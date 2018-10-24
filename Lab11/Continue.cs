using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab11
{
    class Continue
    {
        public Continue(string s)
        {
            StringCont = s;
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
        public bool AnswerValid()
        {
            Console.WriteLine("Do you wish to continue? 'yes' / 'no'");
            stringCont = Console.ReadLine().ToLower();
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
                    Console.WriteLine("Please enter either 'yes' or 'no'");
                    StringCont = Console.ReadLine().ToLower();
                }
            }
        }
    }
}
