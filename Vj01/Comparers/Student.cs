using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comparers

{
    public class Student
    {
        public string Name;
        public double Grade;

        public Student(string Name, double Grade) { this.Name = Name; this.Grade = Grade; }

        public override string? ToString()
        {
            return Name;
        }
    }
}