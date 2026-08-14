using System;
using System.Collections.Generic;
using System.Linq;

class Sample{
	class Ample{
		static void Main(){
		    Console.Write("> ");
		    string user_input = Console.ReadLine();
		    int[] UI = user_input.Split(new[] {',', ' '}, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
			Stack<int> numbers = new Stack<int>(UI);
		
			foreach (int item in numbers){
			    Console.WriteLine(item);
			} 
		    Console.WriteLine($"Peek: {numbers.Peek()}");
		    int latest = numbers.Pop();
		    Console.WriteLine($"Pop: {numbers.Pop()}");
		    numbers.Push(latest);
		    numbers.Push(15);
		    Console.WriteLine("Push: 15");
		    Console.WriteLine($"Count: {numbers.Count()}");
		    foreach(int item in numbers){
		        Console.Write($"{item} ");
		    }
		    
		} } }
