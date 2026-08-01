using System;
using System.Threading;

namespace ConsoleApp1
{
   class Program
    {   
        static void Main(string[] args)
        {
         Console.Write("Write true or false:");
         String input = Console.ReadLine();
         if (input == "true") {
            Console.Write("true");
            Console.Write("\n> true");
         } else {
            Console.Write("false");
            Console.Write("\n> false");
         }
         Console.Write($"\n> {choice}");  
        }
    }
}