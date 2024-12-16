using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public abstract class Employee
    {
        private string name;

        public Employee(string name) { 
            this.name = name;
             }

        public virtual decimal CalculatePay()
        {
            return 0.0m;
        }

        public override string? ToString()
        {
            return $"Employee Name: {name}";
        }
    }
}
