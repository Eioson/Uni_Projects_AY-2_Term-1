using System;
using System.Threading;

namespace ConsoleApp1
{
   class Program
    {   
        private double salary; 
        void setSalary(double input) // public modifier is omitted
        { salary = input; }
        void displaySalary() // re. Ln 9
        { Console.Write($"\nThe salary is \n> {salary}"); }

        static void Main(string[] wha)
        {
            Console.Write("Input Salary Amount \n> ");
            double Amount = Convert.ToDouble(Console.ReadLine());
            Program  wage = new Program();
            wage.setSalary(Amount);
            wage.displaySalary(); }
    }
}