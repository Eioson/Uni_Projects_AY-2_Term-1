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
			} } } }
