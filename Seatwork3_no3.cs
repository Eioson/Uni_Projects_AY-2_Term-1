using System;
using System.Threading;

namespace ConsoleApp1
{

   class Student
    {   public string? student_name;
        public int student_ID;
        public string? course;
        public int year_level; }
   class Program
    {   
        static void Main(string[] wha) {
            Console.Write("What is the student's name? \n> ");
            Student scholar = new Student(); // Instantiates the Student class, thus allowing the Main class to use it's resources.
            scholar.student_name = Console.ReadLine();
            Console.Write("What is their student ID Number? \n> ");
            scholar.student_ID = Convert.ToInt32(Console.ReadLine()); 
            // Int 32 = int var, Int 64 = long var, Int 16 = short var
            Console.Write("What is their course? \n> ");
            scholar.course = Console.ReadLine();
            Console.Write("What is their year level? \n> ");
            scholar.year_level = Convert.ToInt32(Console.ReadLine()); 

            Console.WriteLine($"\n-------------- \nStudent Name \n  > {scholar.student_name} \nStudent ID Number \n  > {scholar.student_ID}"
            + $"\nStudent's Course \n  > {scholar.course} \nStudent Year Level \n  > {scholar.year_level}"); }
    } }