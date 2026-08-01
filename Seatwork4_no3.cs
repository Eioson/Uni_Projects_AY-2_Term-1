using System;
using System.Threading;

namespace ConsoleApp1
{
   class Program
    {   
        string? message = null;

        static void Main(string[] args)
        {

            Console.Write("\nChoose a source of transport"
            + "\nB - Bus"
            + "\nJ - Jeepney"
            + "\nT - Taxi"
            + "\nA - Airplane");

            String ltr = Console.ReadLine();

            switch (ltr?.ToUpperInvariant()){
                case "B":
                    Console.Write("You have chosen the Bus.\n");
                    break;
                case "J":
                    Console.Write("You have chosen the Jeepney.\n");
                    break;
                case "T":
                    Console.Write("You have chosen the Taxi.\n");
                    break;
                case "O":
                    Console.Write("You have chosen the Airplane.\n");
                    break;
                default:
                    Console.Write("This is not part of the choices.");
                    break;
            }
        }
    }
}