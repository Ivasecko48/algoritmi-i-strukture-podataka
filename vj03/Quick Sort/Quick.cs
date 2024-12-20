using System;

namespace QuickSort
{
    public class Quick
    {
        public delegate bool Comparison(object a, object b);

        // QuickSort 
        public static void Sort(object[] array, int left, int right, Comparison cmp)
        {
            if (left >= right) return;

            int last = Partition(array, left, right, cmp);
            Sort(array, left, last - 1, cmp);
            Sort(array, last + 1, right, cmp);
        }

        // Partition 
        public static int Partition(object[] array, int left, int right, Comparison cmp)
        {
            object pivot = array[right];
            int i = left - 1;

            for (int j = left; j < right; j++)
            {
                 if (!cmp(array[j], pivot))
                {
                    i++;
                    Swap(array, i, j);
                }
            }

            Swap(array, i + 1, right);
            return i + 1;
        }


        private static void Swap(object[] array, int first, int second)
        {
            object temp = array[first];
            array[first] = array[second];
            array[second] = temp;
        }
    }
}
