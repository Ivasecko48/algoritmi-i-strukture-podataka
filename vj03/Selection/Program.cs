using System;

namespace Selection
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 9, 8, 4, 11, 5, 7, 3, 1 };

            foreach (int num in array)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();

            Selection.Sort(array, 3);

            Console.WriteLine("Sortirani  niz; ");
            foreach (int num in array)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();
        }
    }
}
