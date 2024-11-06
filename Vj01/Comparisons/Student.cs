using System;
using System.Collections.Generic;
namespace Comparisons{
	public class Student{
		private string name;
		private double grade;
	
	public Student(string name, double grade) {this.name=name;
	this.grade=grade;}

	 public override string? ToString()
        {
            return "Student name: " + name + " and student grade: " + grade;
        }

	public static bool CompareName(object? x, object? y){
		Student student1 = x as Student;
		Student student2 = y as Student;

		if(student1 == null || student2 == null){
			throw new ArgumentNullException("oba studenta moraju biti definirana za usporedbu");
		}

		return student1.name.CompareTo(student2.name) > 0;
	}

	public static bool CompareGrade(object? x, object? y){
		Student student1 = x as Student;
		Student student2 = y as Student;

		if(student1 == null || student2 == null){
			throw new ArgumentNullException("oba studenta moraju biti definirana za usporedbu");
		}
		return student1.grade>student2.grade;
	}
	}
}