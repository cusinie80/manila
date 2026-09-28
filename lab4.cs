using System;

class Stack<T>
{
    private T[] items = new T[100];
    private int topp = -1;

    public void Push(T item)
    {
        if(top==items.length-1)
        {
            Console.WriteLine("Stack Overflow");
            return;
        }
        items[++top] = item;
    }

    public T pop()
    {
        if (topp == -1)
            throw new
    InvalidOpertaionException("Stack Underflow");
        return items[top];

    }
    public T peek()
    {
        if (topp == -1)
            throw new
    InvalidOperationException("Stack is Empty");

        return items[top];
    }
}
class Program
{
    static void main()
    {
        Stack<int> inStack=new Stack<int>();
        inStack.Push(10);
        inStack.Push(20);
        inStack.Push(30);
        Console.WriteLine("Integer Stack:");
        Console.WriteLine("Top Element:"+ inStack.peek());
        Console.WriteLine("Popped Element:" + inStack.pop());
        Console.W
    }
}
