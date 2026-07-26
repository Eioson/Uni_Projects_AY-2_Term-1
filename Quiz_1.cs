using System;
using System.Threading;

namespace ConsoleApp1
{
    class Quiz_1
    {
        

        static void Main(string[] args)
        {
            // Write Your Username Here:
            Console.Write("Enter your username (Or press enter for default): ");

            // User input
            string username = Console.ReadLine();

            // Default Username (Falls back to your name)
            if (username == "")
            {
                username = "Edison";
            }
            
            
            Console.Write("Loading");
            for (int i = 0; i < 3; i++)
            {
                Thread.Sleep(500);
                Console.Write(".");
            }

            // Modern String Interpolation
            Console.WriteLine($"\nUsername is: {username}!");
            Thread.Sleep(500);

            // Keeps the console window open until a key is pressed'
            Console.WriteLine("Press any key to exit...");
            Thread.Sleep(475);
            Console.Read(); // Waits for the user to press a key before closing the console window
        }
    }
}