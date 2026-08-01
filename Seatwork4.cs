using System;
using System.Threading;

namespace ConsoleApp1
{
   class Program
    {   
        string? message = null;

        static void Main(string[] args)
        {
            Console.Write("\nType a Letter: ");
            String ltr = Console.ReadLine();

            switch (ltr){
                case "A":
                    Console.Write("vowel");
                    break;
                case "B":
                    Console.Write("vowel");
                    break;
                case "I":
                    Console.Write("vowel");
                    break;
                case "O":
                    Console.Write("vowel");
                    break;
                case "U":
                    Console.Write("vowel");
                    break;
                default:
                    Console.Write("This is not a vowel.");
                    break;
            }
        }
    }
}