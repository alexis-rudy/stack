using System;
using System.Collections.Generic;

using stack_example;
class Reverse
{
    public static void Run()
    {
        string input = "Hello, World!";
        string reversed = ReverseStringUsingStack(input);
        Console.WriteLine(reversed);
    }
    static string ReverseStringUsingStack(string input)
    {
        Stack<char> stack = new Stack<char>();

        // Push each character of the string onto the stack
        foreach (char c in input)
        {
            stack.Push(c);
        }

        // Pop characters from the stack and build the reversed string
        string reversed = "";
        while (stack.Count > 0)
        {
            reversed += stack.Pop();
        }

        return reversed;
    }
}
