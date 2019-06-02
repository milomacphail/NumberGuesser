using System;
namespace RandomNumberGenerator
{
    public static class Name
    {
        public static void GetName()
        {
            //Ask user's name
            Console.WriteLine();
            Console.WriteLine("Hello, what's your name?");


            //
            string response = Console.ReadLine();

            Console.WriteLine("Oh, hi there, {0}! Let's play a little game of trickery and deceipt.", response);
        }
    }
}
