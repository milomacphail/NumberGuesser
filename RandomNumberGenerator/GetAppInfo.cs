using System;
namespace RandomNumberGenerator
{
    public class GetAppInfo
    {
        public static void AppInfo()
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
    }
}
