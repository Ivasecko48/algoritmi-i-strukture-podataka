using System;

namespace HeapSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 5, 6, 8, 3, 4, 2, 1, 7, 3, 5, 4, 5, 4, 8 };
            Console.WriteLine("Original array:");
            DisplayArray(array);

            Heap.Sort(array);
            Console.WriteLine("\nSorted array:");
            DisplayArray(array);
        }

        static void DisplayArray(int[] array)
        {
            foreach (int num in array)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();
        }
    }
}
