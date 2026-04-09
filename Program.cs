using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POE_Part1
{//start of namespace
    public class Program
    {//start of class
        static void Main(string[] args)
        {//start of main method

            //creating an instance for voice greeting class, with constructor
            new voice_greeting() { };

            //creating an instance for the ascii art to display logo, with a contructor
            new ascii_logo() { };

            //creating an instance for the greeting and user interaction classwith an object name welcome and collect
            greeting_and_userinteraction welcome_and_collect = new greeting_and_userinteraction();

            //Calling the method welcome
            welcome_and_collect.welcome();

            //calling the ask user method
            welcome_and_collect.ask_user();
        }//end of main method
    }//end of class
}//end of namespace
