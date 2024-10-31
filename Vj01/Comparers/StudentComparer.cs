using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comparers
{
	public enum StudentComparerType { Name, Grade }

    public class StudentComparer : IComparer<Student>
    {
        private StudentComparerType criterion;

		public StudentComparer(StudentComparerType criterion)
		 {
		this.criterion = criterion;
		}

		public int Compare(Student x, Student y){
			 switch (criterion)
            {
                case StudentComparerType.Name:
                    return string.Compare(x.ToString(), y.ToString(), StringComparison.OrdinalIgnoreCase);
                case StudentComparerType.Grade:
                    return x.CompareTo(y); 
                default:
                    throw new ArgumentException("Invalid comparison criterion");
            }
		}
	}

	

	



}