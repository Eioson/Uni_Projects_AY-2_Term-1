using System;
using System.Collections.Generic;

class Sample{
	class Ample{
		static void Main(){
			Stack<int> numbers = new Stack<int>();
			
			numbers.Push(80);
			numbers.Push(70);
			numbers.Push(60);
			numbers.Push(50);
			
            numbers.Pop();
            numbers.Pop();
            numbers.Push(50);
            numbers.Push(60);
			foreach (int item in numbers){
			    Console.WriteLine(item);
			} } } }
