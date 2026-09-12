using System;

namespace Task10Application
{
    // Employee class stores employee details and salary information
    class EmployeeTask10
    {
        // Private data members
        private int employeeId;
        private string employeeName;
        private double basicSalary;
        private double allowance;
        private double deduction;

        // Parameterized constructor
        // Initializes employee details
        public EmployeeTask10(
            int employeeId,
            string employeeName,
            double basicSalary,
            double allowance,
            double deduction)
        {
            this.employeeId = employeeId;
            this.employeeName = employeeName;
            this.basicSalary = basicSalary;
            this.allowance = allowance;
            this.deduction = deduction;
        }

        // Method to calculate net salary
        public double CalculateNetSalary()
        {
            // Net salary = Basic + Allowance - Deduction
            return basicSalary + allowance - deduction;
        }

        // Method to display employee details
        public void DisplayDetails()
        {
            Console.WriteLine("\n--- Employee Details ---");
            Console.WriteLine("Employee ID: " + employeeId);
            Console.WriteLine("Employee Name: " + employeeName);
            Console.WriteLine("Basic Salary: " + basicSalary);
            Console.WriteLine("Allowance: " + allowance);
            Console.WriteLine("Deduction: " + deduction);
            Console.WriteLine("Net Salary: " + CalculateNetSalary());
        }
    }

    // Test class
    class TestEmployeeTask10
    {
        static void Main(string[] args)
        {
            // Accept employee details
            Console.Write("Enter Employee ID: ");
            int id = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Employee Name: ");
            string name = Console.ReadLine();

            Console.Write("Enter Basic Salary: ");
            double basic = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter Allowance: ");
            double allowance = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter Deduction: ");
            double deduction = Convert.ToDouble(Console.ReadLine());

            // Create Employee object using constructor
            EmployeeTask10 employee =
                new EmployeeTask10(id, name, basic, allowance, deduction);

            // Display employee details and net salary
            employee.DisplayDetails();

            Console.ReadKey();
        }
    }


}