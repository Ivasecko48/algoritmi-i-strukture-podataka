using System;

namespace Selection
{
    public class Selection
    {
        public static void Sort(int[] array, int startIndex)
        {
            int n = array.Length;

            // Selection Sort
            for (int i = startIndex; i < n - 1; i++)
            {
                int minIndex = i;

                for (int j = i + 1; j < n; j++)
                {
                    if (array[j] < array[minIndex])
                    {
                        minIndex = j;
                    }
                }

                if (minIndex != i)
                {
                    int temp = array[i];
                    array[i] = array[minIndex];
                    array[minIndex] = temp;
                }
            }
        }
    }
}
