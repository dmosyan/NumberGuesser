using System;

//Container for functions
namespace NumberGuesser 
{
    //Main class
    class Program
    {
        //Entry point method
        static void Main(string[] args)
        {
            //Set app vars
            string appName = "Guess The Number";
            string appVersion = "1.0.0";
            string appAuthor = "David";

            //Changing text color
            Console.ForegroundColor = ConsoleColor.Green;

            //Short info about app
            Console.WriteLine("{0}: Version {1} by {2}", appName, appVersion, appAuthor);

            //Reset color after short info
            Console.ResetColor();

            //Ask users name
            Console.WriteLine("What's your name?");
            //Get user input
            string inputName = Console.ReadLine();

            Console.WriteLine("Hello {0}, let's play a game.", inputName);

            //Init correct number
            //int correctNumber = 7;
            //Creating random number
            Random random = new Random();
            int correctNumber = random.Next(1, 10);

            //Init guess
            int guess = 0;

            //Ask user for number
            Console.WriteLine("Guess the number between 1 and 10");

            //While guess is not correct
            while(guess != correctNumber)
            {
                //Get user input
                string input = Console.ReadLine();

                //Make sure that it's number
                if (!int.TryParse(input, out guess)) {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("It's not a number");
                    Console.ResetColor();
                    continue;
                }

                //Change to integer and put in guess
                guess = Int32.Parse(input);

                //Match guess to correct number
                if(guess != correctNumber)
                {
                    //Changing text color to red
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Wrong number, plase try one more time");
                    Console.ResetColor();
                }
            }

            //Change text color
            Console.ForegroundColor = ConsoleColor.Magenta;
            //If guess is correct
            Console.WriteLine("YOU ARE CORRECT!!");
            Console.ResetColor();

            
   


        }
    }
}
