using System;

namespace HeapSort
{
    public class Heap
    {
        public static void Sort(int[] array)
        {
            Heapify(array); 
            Arrange(array); 
        }

        public static void Heapify(int[] array)
        {
            int n = array.Length;
            for (int i = n / 2 - 1; i >= 0; i--)
            {
                BubbleDown(array, i, n - 1);
            }
        }

        public static void Arrange(int[] array)
        {
            int n = array.Length;
            for (int i = n - 1; i > 0; i--)
            {
                Swap(array, 0, i); 
                BubbleDown(array, 0, i - 1); 
            }
        }

        public static void BubbleDown(int[] array, int i, int last)
        {
            int leftChild = 2 * i + 1; 
            int rightChild = 2 * i + 2; 
            int largest = i; 

            if (leftChild <= last && array[leftChild] > array[largest])
            {
                largest = leftChild;
            }

            if (rightChild <= last && array[rightChild] > array[largest])
            {
                largest = rightChild;
            }

            if (largest != i)
            {
                Swap(array, i, largest);
                BubbleDown(array, largest, last); 
            }
        }

        public static void Swap(int[] array, int i, int j)
        {
            int temp = array[i];
            array[i] = array[j];
            array[j] = temp;
        }
    }
}
