using System;

public class Node{
    public int? Data;
    public Node? Next;
    
    public Node(int data){
        Data = data;
        Next = null;
    } }

public class Program {
    public static void Main(){
        Node first = new Node(50);
        Node second = new Node(60);
        Node third = new Node(70);
        Node fourth = new Node(8);
        
        first.Next = second;
        second.Next = third;
        third.Next = fourth;
        fourth.Next = null;

        for (Node current = first; ; current = current.Next){
            if (current == null){
                Console.Write("null");
                return; }
        Console.WriteLine(current.Data);
        } }}
