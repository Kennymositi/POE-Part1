using System;

namespace POE_Part1
{//start of namespace
    public class greeting_and_userinteraction
    {//start of class

        //global variable
        private string username = string.Empty;

        //void method to welcome user
        public void welcome()
        { //start of method

            //message to welcome with text color 
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("╔═════════════════════════════════════════════╗");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("║             WELCOME TO CYBERKORE            ║");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("║              Security At The Core           ║"); 
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("╚═════════════════════════════════════════════╝");
            //reset color
            Console.ResetColor();

        }//end of method

        //method to ask for the user name 
        public void ask_user()
        { //start of method

            //AI  message and name with text color
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("CyberKORE: ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(" Enter your name..");

            //reset the color 
            Console.ResetColor();

            //do while to re-prompt the user for the username
            do
            {//start of do while

                //prompt and text color 
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("USER: ");

                Console.ForegroundColor = ConsoleColor.Gray;
                username = Console.ReadLine();


            } while (!empty()); // end of do while 

        }//end of method ask_user
        //Boolean method to check the username if not empty
        private Boolean empty()
        {//start of boolean method

            //check if not empty by if statement 
            if (username != "")
            {//start of if statement 
             //success message
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write("CyberKORE: ");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Hey " + username);
                //return true
                return true;

            }//end of if statement
            else
            {//start of else 
                //error message 
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write("CyberKORE: ");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Please enter name...");
                //return false 
                return false;



            }//end of else

        }//end of boolean method





    }//end of class
}//end of namespace