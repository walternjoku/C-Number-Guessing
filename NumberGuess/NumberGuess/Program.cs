using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace NumberGuess
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GetAppInfo();// Run GetAppInfo function

            GreetUser();// Ask user name and greet

            while (true)
            {
                //create a random number
                Random random = new Random();

                int correctNumber = random.Next(1, 10);

                //init guess var
                int guess = 0;

                

                //While guess is not correct
                while (guess != correctNumber)
                {
                    string input = Console.ReadLine();

                    //Make sure its a number
                    if (!int.TryParse(input, out guess))
                    {
                        //print error message
                        PrintColour(ConsoleColor.Magenta,"Please enter and actual number");

                        //keep going
                        continue;
                    }


                    guess = Int32.Parse(input);

                    // Match guess number
                    if (guess != correctNumber)
                    {
                        //print error message
                        PrintColour(ConsoleColor.Red, "Wrong number, please try again");
                    }


                }

                //Change text color
             
                //Tell user they are correct
                PrintColour(ConsoleColor.Yellow,"You're Correct!!");


                //Ask to play again
                Console.WriteLine("Play again? [Y to play again or any key to exit]");

                //Get Answer
                string answer = Console.ReadLine().ToUpper();

                if (answer == "Y")
                {
                    continue;
                }
                else
                {
                    return;
                }

                Console.ReadKey();

            }
           
        }

        //Get app info
        static void GetAppInfo()
        {
            //Set App variables
            string appName = "Number Guesser";
            string appVersion = "1.0";
            string appAuthor = "Walt";

            // change text colour
            Console.ForegroundColor = ConsoleColor.Green;

            //write out app info
            Console.WriteLine("{0}: Version {1} by {2}", appName, appVersion, appAuthor);

            // Reset text Color
            Console.ResetColor();
        }

        //Greet user and ask name
        static void GreetUser()
        {
            // Ask user name
            Console.WriteLine("What is your name");

            //Get user name
            string userName = Console.ReadLine();
            Console.WriteLine("Hello {0}, let's play a game...", userName);

            // Ask user for a number
            Console.WriteLine("Hi {0}!, Guess a number between 1 and 10", userName);

        }

        //print colour message
        static void PrintColour(ConsoleColor color, string message)
        {
            //Change text colour
            Console.ForegroundColor = color;

            //Tell user its a wrong number
            Console.WriteLine(message);

            //reset colour
            Console.ResetColor();
        }
    }
}
