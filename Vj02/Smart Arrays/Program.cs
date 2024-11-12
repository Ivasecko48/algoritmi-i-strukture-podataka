using System;
using System.Collections;

namespace SmartArrays{
    class Program
    {
        static void Main(string[] args)
        {
            //23
            SmartArray smarty = new SmartArray(6);

            // Step 24
            for (int i = 0; i <= 8; i++)
            {
                smarty.Add(i);
            }

            Console.WriteLine("Contents of SmartArray:");
            for (int i = 0; i < smarty.Length; i++)
            {
                Console.Write(smarty[i] + " ");
            }
            Console.WriteLine("");

            // Step 26
            IEnumerator enumerator = smarty.GetEnumerator();
            Console.WriteLine("Using enumerator:");
            while (enumerator.MoveNext())
            {
                int i = (int)enumerator.Current;
                Console.Write(i + " ");
            }
            Console.WriteLine("");


            // Step 27
            Console.WriteLine("Removing elements:");
            for (int i = smarty[0]; smarty.Length > 0; i++)
            {
                Console.WriteLine("Removing: " + smarty[0]);
                smarty.Remove(smarty[0]);

                for (int j = 0; j < smarty.Length; j++)
                {
                    Console.Write(smarty[j] + " ");
                }
            }
        }
    }
}
