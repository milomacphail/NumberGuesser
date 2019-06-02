using System;

namespace RandomNumberGenerator
{
    class Program
    {
        public static void Main(string[] args)
        {

            GetAppInfo();
            GetName();
            GamePlay();
        }

        static void GetAppInfo()
        {
            string appName = "Number Generator and Guesser";
            string appVersion = "1.0.0";
            string appAuthor = "Milo MacPhail";

            //change text color
            Console.ForegroundColor = ConsoleColor.Gray;

            Console.WriteLine("{0}: Version: {1} by {2}", appName, appVersion, appAuthor);

            //reset color
            Console.ResetColor();

        }

        static void GetName()
        {
            //Ask user's name
            Console.WriteLine();
            Console.WriteLine("Hello, what's your name?");


            //
            string response = Console.ReadLine();

            Console.WriteLine("Oh, hi there, {0}! Let's play a little game of trickery and deceipt.", response);
        }

        static void GamePlay()
        {
            while (true)
            {
                //Set correct number
                Random random = new Random();

                int correctNumber = random.Next(1, 11);

                //init guess var
                int guess = 0;

                Console.WriteLine("Guess a number between 1 and 10.");

                //game conditions
                while (guess != correctNumber)
                {
                    string userGuess = Console.ReadLine();

                    if (!int.TryParse(userGuess, out guess))
                    {
                        //error message
                        PrintColorMessage(ConsoleColor.Red, "Guess a real number.");

                        continue;
                    }

                    //Cast to int and put into guess variable
                    guess = Int32.Parse(userGuess);

                    //Match to correct number
                    if (guess != correctNumber)
                    {
                        PrintColorMessage(ConsoleColor.Red, "Guess again.");
                    }

                }

                //victory message
                PrintColorMessage(ConsoleColor.Green, "Great job you!.");

                //Play again?
                Console.WriteLine("Would you like to test me again? [Y or N]");
                string answer = Console.ReadLine().ToUpper();

                if (answer == "Y")
                {
                    continue;
                }
                else if (answer == "N")
                {
                    Console.WriteLine("Coward.");
                    return;
                }
                else
                {
                    PrintColorMessage(ConsoleColor.Red, "YOU HAD ONE JOB!");
                    return;
                }

            }
        }

        static void PrintColorMessage(ConsoleColor color, string message)
        {
            Console.ForegroundColor = color;

            Console.WriteLine(message);

            Console.ResetColor();

        }
    }

}
