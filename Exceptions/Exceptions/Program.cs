using System;

namespace Exceptions
{
    class Program
    {
        static int ReadInt()
        {
            int result;
            while (true)
            {
                try
                {
                    Console.Write("Enter an int: ");
                    result = int.Parse(Console.ReadLine());
                    return result; // vračanje integera
                }
                catch (FormatException)
                {
                    Console.WriteLine("Input string was not in a correct format.");
                }
                finally
                {
                    Console.WriteLine("Finally invoked!");
                }
            }
        }

        static void Main(string[] args)
        {
            try
            {+
                int a = ReadInt();
                int b = ReadInt();
                int result = a / b;
                Console.WriteLine($"Result of division: {result}");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Cannot divide by zero.");
            }
            finally
            {
                Console.WriteLine("Program finished.");
            }
        }
    }
}
