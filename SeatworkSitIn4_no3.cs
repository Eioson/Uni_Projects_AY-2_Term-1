using System;

namespace Consoleapp1{
public class Program
{
    public static void Main(string[] args) {
        int choice = 1, answer = 0;
        do{
        Console.Write("\nFirst Number \n> ");
        int num1 = Convert.ToInt32(Console.ReadLine());
		Console.Write("\nSecond Number \n> ");
        int num2 = Convert.ToInt32(Console.ReadLine());
        
        Console.Write("Choose one option out of these:" + "\n1 - Add" + "\n2 - Subtract" + "\n3 - Multiply" + "\n4 - Divide" + "\n0 - Exit" + "\n   > ");
        choice = Convert.ToInt32(Console.ReadLine());
		switch (choice){
			case 1:
				answer = num1 + num2;
				Console.Write($"Your answer is {answer}\n");
				break;
			case 2:
				answer = num1 - num2;
				Console.Write($"Your answer is {answer}\n");
				break;
			case 3:
				answer = num1 * num2;
				Console.Write($"Your answer is {answer}\n");
				break;
	    	case 4:
				if (num2 == 0){
				    Console.Write("Math Error. Change your second number into a different number\n");
				    break; }
				answer = num1 / num2;
				Console.Write($"Your answer is {answer}\n");
				break;
			case 0:
				Console.Write($"\nExiting the Program...\n");
				return;
			default:
			    Console.Write("invalid choice");
			    break; } 
        Console.Write("\nDo you want to continue? (1 - Yes, 0 - No) \n   > ");
        choice = Convert.ToInt32(Console.ReadLine());
        if (choice == 0){
            Console.Write($"\nExiting the Program...\n");
            return; } }
    while (choice != 0);
} } }