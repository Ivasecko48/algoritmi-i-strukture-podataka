using System;

namespace BasicStructure
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int i = 10;
            char c = 'A';
            float f = 3.14f;
            double d = 20.99;
            decimal dec = 100.50m;
            string s = "Hello World!";
            
            Console.WriteLine($"Integer: {i}");
            Console.WriteLine($"Character: {c}");
            Console.WriteLine($"Float: {f}");
            Console.WriteLine($"Double: {d}");
            Console.WriteLine($"Decimal: {dec}");
            Console.WriteLine($"String: {s}");

            Console.Write("Enter the radius of the circle: ");
            double radius;
            
            while (!double.TryParse(Console.ReadLine(), out radius) || radius <= 0)
            {
                Console.WriteLine("Invalid input. Please enter a positive number for the radius:");
            }
            
            Circle circle = new Circle(radius);

            Console.WriteLine(circle.ToString());
        }
    }
}
