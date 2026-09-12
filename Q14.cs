using System;

namespace Task14Application
{
    // Employee class demonstrates private and public access
    class EmployeeTask14
    {
        // Public data members
        public int employeeId;
        public string employeeName;

        // Private salary cannot be accessed directly outside this class
        private double salary;

        // Constructor to initialize employee details
        public EmployeeTask14(int employeeId, string employeeName, double salary)
        {
            this.employeeId = employeeId;
            this.employeeName = employeeName;

            // Store salary using private data member
            this.salary = salary;
        }

        // Public method to set/update salary
        // Provides controlled access to private salary
        public void SetSalary(double newSalary)
        {
            if (newSalary >= 0)
            {
                salary = newSalary;
            }
            else
            {
                Console.WriteLine("Salary cannot be negative.");
            }
        }

        // Public method to get salary
        // Provides controlled access to private salary
        public double GetSalary()
        {
            return salary;
        }

        // Method to display employee details
        public void Display()
        {
            Console.WriteLine("\n--- Employee Details ---");
            Console.WriteLine("Employee ID: " + employeeId);
            Console.WriteLine("Employee Name: " + employeeName);
            Console.WriteLine("Salary: " + GetSalary());
        }
    }

    // Test class
    class TestEmployeeTask14
    {
        static void Main(string[] args)
        {
            // Create Employee object
            EmployeeTask14 employee =
                new EmployeeTask14(101, "Rahul", 30000);

            // Display employee information
            employee.Display();

            Console.WriteLine();

            // Update salary through public method
            employee.SetSalary(35000);

            Console.WriteLine("After Salary Update:");
            Console.WriteLine("Salary: " + employee.GetSalary());

            Console.ReadKey();
        }
    }


}