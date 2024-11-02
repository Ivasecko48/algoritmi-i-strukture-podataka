using System.Collections;

namespace Comparers
{
    public class Bubble
    {
        public static void Sort(Student[] students, IComparer<Student> comparer)
        {
            for (int i = 0; i < students.Length; i++)
            {
                for (int j = i + 1; j < students.Length; j++)
                {
                    if (comparer.Compare(students[j], students[i]) < 0)
                    {
                        Student temp = students[j];
                        students[j] = students[i];
                        students[i] = temp;
                    }
                }
            }
        }
    }
}
