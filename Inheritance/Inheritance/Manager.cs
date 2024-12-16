using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
	public class Manager : Employee
	{
		private decimal salary;

		public Manager(string name, decimal salary) : base(name)
		{
			this.salary = salary;
		}

		public override decimal CalculatePay()
		{
			return salary;
		}
	}
}