using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comparables

{
    public class Student : IComparable<Student>
    {
        private string name;
        private double grade;

        public Student(string name, double grade) { this.name = name; this.grade = grade; }

        public int CompareTo(Student? other)
        {
             if (other == null) return 1;

             return this.grade.CompareTo(other.grade);
        }

        public override string? ToString()
        {
            return "Student name: " + name + " and student grade: " + grade;
        }
    }
}