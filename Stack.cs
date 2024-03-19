using System;

class Node
{
    public int data;
    public Node next;

    public Node(int new_data)
    {
        data = new_data;
        next = null;
    }
}

class Stack
{
    private Node top;

    public Stack()
    {
        top = null;
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
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        Stack newStack = new Stack();
        newStack.Push(1);
        newStack.Push(5);
        newStack.Push(10);
        newStack.Push(15);
        newStack.Pop();
        newStack.ShowStack();
    }
}