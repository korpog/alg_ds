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

class Stack
{
    private Node top;

    public Stack()
    {
        this.top = null;
    }

    public void Push(int data)
    {
        Node node = new Node(data);
        node.next = top;
        top = node;
    }

    public int Pop()
    {
        if (top == null) return -1;

        int val = top.data;
        top = top.next;
        return val;
    }

    public void ShowStack()
    {
        Node current = top;
        while (current != null)
        {
            Console.Write(current.data + " ");
            current = current.next;
        }
        Console.WriteLine();
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        Stack newStack = new Stack();
        newStack.Push(5);
        newStack.ShowStack();
        newStack.Push(10);
        newStack.Push(15);
        newStack.ShowStack();
        newStack.Pop();
        newStack.ShowStack();
    }
}