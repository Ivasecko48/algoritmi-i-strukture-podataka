using System;
using SingleList;

namespace Stack{
class Program
{
    static void Main(string[] args)
    {
        Stack stack = new Stack();

        stack.Push("Kim");
        stack.Push("Iva");
        stack.Push("Lovre");
        stack.Push("Jure");
		stack.Push("Josip");

        stack.Display();

        Console.WriteLine("\nPopping:");
        try
        {
            while (!stack.IsEmpty())
            {
                Console.WriteLine($"Popped: {stack.Pop()}");

                Console.WriteLine("POP!");
                stack.Display();
            }
        }
        catch (InvalidOperationException ex)
        {
            Console.WriteLine($"Exception caught: {ex.Message}");
        }
    }
}
}