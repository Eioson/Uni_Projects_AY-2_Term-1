using System;

public class Node{
    public int? Data;
    public Node? Next;
    public Node? Back;
    
    public Node(int data){
        Back = null;    
        Data = data;
        Next = null;
    } }

public class Program {
    public static void Main(){
        Node first = new Node(1);
        Node second = new Node(2);
        Node third = new Node(3);
        Node fourth = new Node(4);
        Node fifth = new Node(5);
        
        first.Back = null; first.Next = second;
        second.Back = first; second.Next = third;
        third.Back = second; third.Next = fourth;
        fourth.Back = third; fourth.Next = fifth;
        fifth.Back = fourth; fifth.Back = null;
        
        Node? current = first;
        while (current != null){
            Console.Write(current.Data + (current.Next != null ? " <-> " : ""));
            current = current.Next; }
            
        Console.WriteLine();
    } }
