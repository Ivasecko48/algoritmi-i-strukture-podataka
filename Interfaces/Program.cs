using System;

namespace Interfaces{
	public class Program
	{
		public static void Main(string[] args)
		{
			Student student1 = new Student("Ana", 4.9f);
			Student student2 = new Student("Bob", 4.1f);
			Student student3 = new Student("Ivo", 4.5f);
			Student student4 = new Student("Iva", 3.6f);

			Console.WriteLine(student1);
			Console.WriteLine(student2);
			Console.WriteLine(student3);
			Console.WriteLine(student4);

			Student[] students = new Student[] { student1, student2, student3, student4 };

			float totalGrade = 0.0f;
			foreach (Student student in students)
			{
				totalGrade += student.GetGrade();
			}
			float averageGrade = totalGrade / students.Length;
			Console.WriteLine($"\nAverage Grade: {averageGrade}");

			Array.Sort(students);

			Console.WriteLine("\nSorted Students by Grade:");
			foreach (Student student in students)
			{
				Console.WriteLine(student);
			}
		}
	}
}