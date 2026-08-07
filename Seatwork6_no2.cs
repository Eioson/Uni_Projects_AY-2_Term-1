using System;
					
public class Node{
	public int Data;
	public Node Next;
	
	public Node(int data){
		Data = data;
		Next = null;
	}
}
public class Program
{
	public static void Main()
	{		
		Node first = new Node(1010);
		Node second = new Node(1111);
		Node third = new Node(1100);
		Node fourth = new Node(1011);
		first.Next = second;
		second.Next = third;
		third.Next = fourth;
		fourth.Next = null;
		
		for (Node current = first; ; current = current.Next){
			if (current == null){
				Console.Write(current?.Data ?? 0);
				return;
			}
			Console.WriteLine(current?.Data ?? 0);
		}
	}
}
