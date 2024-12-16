using System;

namespace QuickSort
{
    class Program
    {
        static void Main(string[] args)
        {
            Student[] students = {
                new Student("Ivo", 4.1),
                new Student("Ana", 4.9),
                new Student("Iva", 4.3),
                new Student("Boban", 4.5),
                new Student("Joe", 4.7),
				new Student("Toma", 4.4),
                new Student("Iko", 4.6),
            };

            Console.WriteLine("Original list of students:");
            foreach (var student in students)
            {
                Console.WriteLine(student);
            }

			// Partition
			Quick.Partition(students,0,scd tudents.Length - 1,Student.CompareName);
			Console.WriteLine("\nPartitioned by name:");
            foreach (var student in students)
            {
                Console.WriteLine(student);
            }

            // Sort by name
            Quick.Sort(students, 0, students.Length - 1, Student.CompareName);
            Console.WriteLine("\nSorted by name:");
            foreach (var student in students)
            {
                Console.WriteLine(student);
            }

            // Sort by grade
            Quick.Sort(students, 0, students.Length - 1, Student.CompareGrade);
            Console.WriteLine("\nSorted by grade:");
            foreach (var student in students)
            {
                Console.WriteLine(student);
            }
        }
    }
}
