using System;
using System.Collections.Generic;
namespace Comparisons{
	class program{
		static void Main(string[] args){
			Student[] students = {
		new Student ("Ivo", 4.1),
		new Student ("Ana", 4.9),
		new Student ("Iva", 4.3),
		new Student ("Bob", 4.5),
		new Student ("Joe", 4.7)
		};
		Console.WriteLine("Studenti prije:");

		foreach(Student i in students){
			Console.WriteLine(i.ToString());
		}

		Bubble.Sort(students, Student.CompareName);
			Console.WriteLine("Studenti sortirani po imenu:");

		foreach(Student i in students){
			Console.WriteLine(i.ToString());
		}

		Bubble.Sort(students, Student.CompareGrade);
		Console.WriteLine("Studenti sortirani po ocjeni:");

		foreach(Student i in students){
			Console.WriteLine(i.ToString());
		}

	
	}
	}
}
