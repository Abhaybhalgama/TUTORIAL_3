using System;

namespace Task16Application
{
    // Base class containing common employee information
    class EmployeeTask16
    {
        protected int employeeId;
        protected string employeeName;

        // Constructor of base class
        public EmployeeTask16(int employeeId, string employeeName)
        {
            this.employeeId = employeeId;
            this.employeeName = employeeName;
        }

        // Method to display common employee details
        public void DisplayEmployee()
        {
            Console.WriteLine("Employee ID: " + employeeId);
            Console.WriteLine("Employee Name: " + employeeName);
        }
    }

    // Derived class for permanent employees
    class PermanentEmployeeTask16 : EmployeeTask16
    {
        private double basicSalary;
        private double allowance;

        // Constructor
        public PermanentEmployeeTask16(
            int employeeId,
            string employeeName,
            double basicSalary,
            double allowance)
            : base(employeeId, employeeName)
        {
            this.basicSalary = basicSalary;
            this.allowance = allowance;
        }

        // Calculate salary for permanent employee
        public double CalculateSalary()
        {
            return basicSalary + allowance;
        }

        // Display permanent employee details
        public void Display()
        {
            Console.WriteLine("\n--- Permanent Employee ---");
            DisplayEmployee();
            Console.WriteLine("Basic Salary: " + basicSalary);
            Console.WriteLine("Allowance: " + allowance);
            Console.WriteLine("Total Salary: " + CalculateSalary());
        }
    }

    // Derived class for contract employees
    class ContractEmployeeTask16 : EmployeeTask16
    {
        private double hoursWorked;
        private double ratePerHour;

        // Constructor
        public ContractEmployeeTask16(
            int employeeId,
            string employeeName,
            double hoursWorked,
            double ratePerHour)
            : base(employeeId, employeeName)
        {
            this.hoursWorked = hoursWorked;
            this.ratePerHour = ratePerHour;
        }

        // Calculate salary for contract employee
        public double CalculateSalary()
        {
            return hoursWorked * ratePerHour;
        }

        // Display contract employee details
        public void Display()
        {
            Console.WriteLine("\n--- Contract Employee ---");
            DisplayEmployee();
            Console.WriteLine("Hours Worked: " + hoursWorked);
            Console.WriteLine("Rate Per Hour: " + ratePerHour);
            Console.WriteLine("Total Salary: " + CalculateSalary());
        }
    }

    // Test class
    class TestEmployeeTask16
    {
        static void Main(string[] args)
        {
            // Create permanent employee object
            PermanentEmployeeTask16 permanent =
                new PermanentEmployeeTask16(
                    101,
                    "Rahul",
                    30000,
                    5000
                );

            // Create contract employee object
            ContractEmployeeTask16 contract =
                new ContractEmployeeTask16(
                    102,
                    "Priya",
                    160,
                    200
                );

            // Display salary details
            permanent.Display();
            contract.Display();

            Console.ReadKey();
        }
    }


}