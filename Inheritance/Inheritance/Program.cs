using System;
using System.Collections.Generic;

namespace Inheritance
{
    internal class Program{
        public static void Main()
        {
            // Employee e = new Employee("John"); // definiranje objekta apstraktna klasa stvara error u kompajleru

            Worker worker1 = new Worker("Iva", 20.5m, 40);
            Worker worker2 = new Worker("Joe", 18.5m, 35);

            Manager ceo = new Manager("Ana", 1500m);

            List<Employee> staff = new List<Employee>();

            staff.Add(worker1);
            staff.Add(worker2);
            staff.Add(ceo);

            decimal totalPay = 0.0m;

            Console.WriteLine("Employees:");
            foreach (Employee employee in staff)
            {
                Console.WriteLine(employee.ToString());
            }

            foreach (Employee employee in staff)
            {
                totalPay += employee.CalculatePay();
            }

            Console.WriteLine($"\nPayroll: {totalPay:C}");
        }
}
}
