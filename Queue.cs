using System;

class Node
{
    public int data;
    public Node next;

    public Node(int data)
    {
        this.data = data;
        this.next = null;
    }
}

class Queue
{
    public Node front, back;

    public Queue()
    {
        this.front = null;
        this.back = null;
    }

    public void Enqueue(int data)
    {
        Node node = new Node(data);

        if (this.back == null)
        {
            this.front = this.back = node;
            return;
        }

        this.back.next = node;
        this.back = node;
    }

    public void Dequeue()
    {
        if (this.front == null)
        {
            return;
        }

        this.front = this.front.next;

        if (this.front == null)
        {
            this.back = null;
        }
    }

    public void ShowQueue() {
        Node current = front;
        while (current != null) {
            Console.Write(current.data + " ");
            current = current.next;
        }
        Console.WriteLine();
    }
}

public class Program {
    public static void Main(string[] args) {
        Queue newQueue = new Queue();
        newQueue.Enqueue(5);
        newQueue.Enqueue(10);
        newQueue.ShowQueue();
        newQueue.Enqueue(15);
        newQueue.ShowQueue();
        newQueue.Dequeue();
        newQueue.ShowQueue();
    }
}