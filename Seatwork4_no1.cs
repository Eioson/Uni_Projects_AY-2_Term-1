// Using While n If/Else
using System;
class Program
{
    static void Main(string[] args) {
        int input = 1;
        while (input !=0 ){
        Console.Write ("Enter a number \n> ");
        input = Convert.ToInt32(Console.ReadLine());
        if (input != 0) {
            if (input > 0) { Console.WriteLine("Lower"); } 
            else { Console.WriteLine("Higher"); }
            } }
        Console.WriteLine("Success");
}}