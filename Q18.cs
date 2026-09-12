using System;

namespace Task18Application
{
    // Base Employee class
    class EmployeeTask18
    {
        protected int employeeId;
        protected string employeeName;

        // Constructor
        public EmployeeTask18(int employeeId, string employeeName)
        {
            this.employeeId = employeeId;
            this.employeeName = employeeName;
        }

        // Virtual method that will be overridden
        public virtual void GenerateSalarySlip()
        {
            Console.WriteLine("Employee Salary Slip");
        }
    }

    // Permanent employee class
    class PermanentEmployeeTask18 : EmployeeTask18
    {
        private double basicSalary;
        private double allowance;
        private double deduction;

        // Constructor
        public PermanentEmployeeTask18(
            int employeeId,
            string employeeName,
            double basicSalary,
            double allowance,
            double deduction)
            : base(employeeId, employeeName)
        {
            this.basicSalary = basicSalary;
            this.allowance = allowance;
            this.deduction = deduction;
        }

        // Override salary slip method
        public override void GenerateSalarySlip()
        {
            double netSalary = basicSalary + allowance - deduction;

            Console.WriteLine("\n--- Permanent Employee Salary Slip ---");
            Console.WriteLine("Employee ID: " + employeeId);
            Console.WriteLine("Employee Name: " + employeeName);
            Console.WriteLine("Basic Salary: " + basicSalary);
            Console.WriteLine("Allowance: " + allowance);
            Console.WriteLine("Deduction: " + deduction);
            Console.WriteLine("Net Salary: " + netSalary);
        }
    }

    // Contract employee class
    class ContractEmployeeTask18 : EmployeeTask18
    {
        private double hoursWorked;
        private double ratePerHour;

        // Constructor
        public ContractEmployeeTask18(
            int employeeId,
            string employeeName,
            double hoursWorked,
            double ratePerHour)
            : base(employeeId, employeeName)
        {
            this.hoursWorked = hoursWorked;
            this.ratePerHour = ratePerHour;
        }

        // Override salary slip method
        public override void GenerateSalarySlip()
        {
            double netSalary = hoursWorked * ratePerHour;

            Console.WriteLine("\n--- Contract Employee Salary Slip ---");
            Console.WriteLine("Employee ID: " + employeeId);
            Console.WriteLine("Employee Name: " + employeeName);
            Console.WriteLine("Hours Worked: " + hoursWorked);
            Console.WriteLine("Rate Per Hour: " + ratePerHour);
            Console.WriteLine("Net Salary: " + netSalary);
        }
    }

    // Test class
    class TestEmployeeTask18
    {
        static void Main(string[] args)
        {
            // Create permanent employee object
            EmployeeTask18 permanent =
                new PermanentEmployeeTask18(
                    101,
                    "Rahul",
                    30000,
                    5000,
                    2000
                );

            // Create contract employee object
            EmployeeTask18 contract =
                new ContractEmployeeTask18(
                    102,
                    "Priya",
                    160,
                    200
                );

            // Call overridden methods
            permanent.GenerateSalarySlip();
            contract.GenerateSalarySlip();

            Console.ReadKey();
        }
    }


}