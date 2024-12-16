using System;

namespace Queue{
class Program
{
    static void Main(string[] args)
    {
        Queue queue = new Queue();

        queue.Enqueue("Kim");
        queue.Enqueue("Iva");
        queue.Enqueue("Lovre");
        queue.Enqueue("Jure");
		queue.Enqueue("Josip");

        queue.Display();

        Console.WriteLine("\nDeQing...");
        try
        {
            while (!queue.IsEmpty())
            {
                Console.WriteLine($"Dequeued: {queue.Dequeue()}");

                queue.Display();
            }
        }
        catch (InvalidOperationException ex)
        {
            Console.WriteLine($"Exception caught: {ex.Message}");
        }
    }
}
}