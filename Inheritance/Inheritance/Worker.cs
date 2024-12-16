using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
   public class Worker : Employee
{
    private decimal wage;
    private int hours;

    public Worker(string name, decimal wage, int hours) : base(name)
    {
        this.wage = wage;
        this.hours = hours;
    }

    public override decimal CalculatePay()
    {
        return wage * hours;
    }
}
}