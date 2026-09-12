//14.A program to restrict direct access to employee salary while allowing 
//    controlled access through public methods.

//(Inheritance)

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TUTORIAL_3
{
    using System;

    class Employee
    {
        private double salary;   // Direct access is restricted

        // Constructor
        public Employee(double salary)
        {
            this.salary = salary;
        }

        // Public method to get salary
        public double GetSalary()
        {
            return salary;
        }

        // Public method to set salary with validation
        public void SetSalary(double salary)
        {
            if (salary > 0)
            {
                this.salary = salary;
            }
            else
            {
                Console.WriteLine("Invalid salary!");
            }
        }
    }

    // Inheritance
    class Manager : Employee
    {
        public Manager(double salary) : base(salary)
        {
        }

        public void DisplaySalary()
        {
            Console.WriteLine("Employee Salary: " + GetSalary());
        }
    }

    class Program
    {
        static void Main()
        {
            Manager m = new Manager(50000);

            // Controlled access through public methods
            m.DisplaySalary();

            m.SetSalary(60000);
            m.DisplaySalary();

            // Not allowed:
            // m.salary = 70000;
            // Error: 'Employee.salary' is inaccessible due to its protection level
        }
    }
}
