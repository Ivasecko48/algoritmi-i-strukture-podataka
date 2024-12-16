using System;

namespace Interfaces{
	public class Student : IComparable<Student>
	{
		private string name;
		private float grade;

		public Student(string name, float grade)
		{
			this.name = name;
			this.grade = grade;
		}

		public void Learn()
		{
			Console.WriteLine($"{name} is learning.");
		}

		public float GetGrade()
		{
			return grade;
		}

		public override string ToString()
		{
			return $"Student Name: {name}, Grade: {grade}";
		}

		public int CompareTo(Student other)
		{
			if (other == null) return 1;
			return other.grade.CompareTo(this.grade);
		}
	}
}