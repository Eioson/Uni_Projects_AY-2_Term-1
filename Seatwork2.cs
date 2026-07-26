using System;
using System.Threading;

namespace ConsoleApp1
{
    class Seatwork2
    {   
        static void Main(string[] args)
        {
            // Create a program that movie title, genre, actor and theme
            Console.Write("Favorite Game: ");
            String Game = Console.ReadLine();
            Console.Write("Game Type: ");
            String Type = Console.ReadLine();
            Console.Write("Game Genre: ");
            String Genre = Console.ReadLine();
            Console.Write("Game Platorm: ");
            String Platorm = Console.ReadLine();
            Console.Write("OS: ");
            String OS = Console.ReadLine();
            
            Console.Write($"Favourite Game: {Game}"
                + $"\n Type:{Type}"
                + $"\n Genre: {Genre}"
                + $"\n Platorm: {Platorm}"
                + $"\n OS: {OS}");

        }
    }
}