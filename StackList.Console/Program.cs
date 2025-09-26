﻿using StackUsingList;

var stack = new StackUsingList<string>();
var opt = string.Empty;

try
{
    do
    {
        opt = Menu();
        switch (opt)
        {
            case "1":
                Console.Write("Enter item: ");
                stack.Push(Console.ReadLine()!);
                break;
            case "2":
                Console.WriteLine(stack.Peek());
                break;
            case "3":
                Console.WriteLine(stack.Pop());
                break;
            default:
                break;            
        }
    }
    while (opt != "0");
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}

string Menu()
{
    Console.WriteLine("1. Push");
    Console.WriteLine("2. Peek");
    Console.WriteLine("3. Pop");
    Console.WriteLine("0. Exit");
    Console.Write("Select your option: ");
    return Console.ReadLine()!;
}