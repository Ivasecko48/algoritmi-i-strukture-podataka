using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comparers
{
	public enum StudentComparerType { Name, Grade }

    public class StudentComparer : IComparer
    {
        private StudentComparerType criterion;

		public StudentComparer(StudentComparerType criterion)
		 {
		this.criterion = criterion;
		}

		public int Compare(Student? x, Student? y) // Nullable parameters
{
    if (x == null && y == null) return 0;
    if (x == null) return -1;
    if (y == null) return 1;

    // Compare based on Name or Grade
    return criterion switch
    {
        StudentComparerType.Name => string.Compare(x.Name, y.Name, StringComparison.Ordinal), // Added StringComparison.Ordinal
        StudentComparerType.Grade => x.Grade.CompareTo(y.Grade),
        _ => 0
    };
}
	}

	

	



}