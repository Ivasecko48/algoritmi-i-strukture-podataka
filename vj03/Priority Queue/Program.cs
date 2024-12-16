using System;

namespace Heap
{
    class Program
    {
        static void Main(string[] args)
        {
                Heap heap = new Heap(10);
				try{
                Console.WriteLine("Inserting values into the heap:");
                for (int i = 0; i < 11; i++) 
                    heap.Insert(i);
				}
				catch (Exception x){
					Console.WriteLine(x.Message);
				}
				heap.Display();

            try{
                Console.WriteLine("Retrieving values from the heap:");
                while (true)
                {
                    int priority = heap.Retrieve();
                    heap.Display();
                }
            }
            catch (Exception x)
            {
                Console.WriteLine(x.Message); 
            }
		}
    }
}
