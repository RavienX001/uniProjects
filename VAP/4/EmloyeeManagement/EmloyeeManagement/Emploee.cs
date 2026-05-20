using System;
using System.Collections.Generic;
using System.Text;

namespace EmloyeeManagement
{
    internal class Employee
    {
        private string name;
        private int salary;

        public void SetDetails(string name, int salary) { 
            this.name = name;
            this.salary = salary;
        }

        public void DisplayDetails() {
            Console.WriteLine("name is "+ name);
            Console.WriteLine("salary is " + salary);
        }
    }
}
