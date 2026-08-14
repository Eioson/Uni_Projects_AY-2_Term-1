using System;

public class Node{
    public int? Data;
    public Node? Next;
    
    public Node(int data){
        Data = data;
        Next = null;
    }
}

public class Program {
    public static void Main(){
        Node first = new Node(50);
        Node second = new Node(60);
        Node third = new Node(70);
        Node fourth = new Node(80);
        
        first.Next = second;
        second.Next = third;
        third.Next = fourth;
        fourth.Next = first;
        
        Node? current = first;
        int loop = 0;
        if (current != null){
            do{
                Console.WriteLine(current.Data ?? 0);
                if (current.Next == null){ break;}
                current = current.Next;
                loop++;
            } while (loop != 5);
        }
    }
}
