using System;
using System.Collections.Generic;

/// <summary>
/// MyStack is a custom implementation of a stack data structure using a List<int> as the underlying container.
/// </summary>
/// <author>Yanzhi Wang</author>
/// <remarks>
/// This implementation assumes that the stack is a LIFO (Last-In-First-Out) data structure.
/// </remarks>
class MyStack
{
    private List<int> list;

    /// <summary>
    /// Constructs a new MyStack object with an empty list.
    /// </summary>
    public MyStack()
    {
        list = new List<int>();
    }

    /// <summary>
    /// Adds a new element to the top of the stack.
    /// </summary>
    /// <param name="n">The integer value to push onto the stack.</param>
    public void Push(int n)
    {
        list.Add(n);
    }

    /// <summary>
    /// Removes and returns the element at the top of the stack.
    /// </summary>
    /// <returns>The integer value at the top of the stack.</returns>
    /// <exception cref="InvalidOperationException">Thrown when the stack is empty.</exception>
    public int Pop()
    {
        if (list.Count == 0)
        {
            throw new InvalidOperationException("Stack is empty");
        }
        int lastIndex = list.Count - 1;
        int lastValue = list[lastIndex];
        list.RemoveAt(lastIndex);
        return lastValue;
    }

    /// <summary>
    /// Returns the element at the top of the stack without removing it.
    /// </summary>
    /// <returns>The integer value at the top of the stack.</returns>
    /// <exception cref="InvalidOperationException">Thrown when the stack is empty.</exception>
    public int Peek()
    {
        if (list.Count == 0)
        {
            throw new InvalidOperationException("Stack is empty");
        }
        return list[list.Count - 1];
    }

    /// <summary>
    /// Returns the number of items in the stack.
    /// </summary>
    public int Count
    {
        get { return list.Count; }
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Create a new stack
        MyStack stack = new MyStack();

        // Push some values onto the stack
        stack.Push(1);
        stack.Push(2);
        stack.Push(3);

        // Peek at the top value on the stack
        int topValue = stack.Peek();
        Console.WriteLine("Top value is: {0}", topValue);

        // Pop some values off the stack
        int value1 = stack.Pop();
        int value2 = stack.Pop();

        // Peek at the top value on the stack again
        topValue = stack.Peek();
        Console.WriteLine("Top value is now: {0}", topValue);

        // Push another value onto the stack
        stack.Push(4);

        // Pop the remaining value off the stack
        int value3 = stack.Pop();

        // Verify that the stack is now empty
        bool isEmpty = (stack.Count == 0);
        Console.WriteLine("Stack is empty: {0}", isEmpty);
    }
}
