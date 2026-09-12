using System;

namespace Task23Application
{
    // Abstract base class
    abstract class AccountTask23
    {
        // Protected data member
        protected double principal;

        // Constructor
        public AccountTask23(double principal)
        {
            this.principal = principal;
        }

        // Abstract method
        // Derived classes must implement this method
        public abstract double CalculateInterest();

        // Common method to display principal
        public void DisplayPrincipal()
        {
            Console.WriteLine("Principal Amount: " + principal);
        }
    }

    // Savings account class
    class SavingsAccountTask23 : AccountTask23
    {
        private double rate = 5.0;

        // Constructor
        public SavingsAccountTask23(double principal)
            : base(principal)
        {
        }

        // Implement abstract method
        public override double CalculateInterest()
        {
            // Simple interest = P × R × T / 100
            // Here T = 1 year
            return principal * rate / 100;
        }

        // Display savings account information
        public void Display()
        {
            Console.WriteLine("\n--- Savings Account ---");
            DisplayPrincipal();
            Console.WriteLine("Interest Rate: " + rate + "%");
            Console.WriteLine("Interest: " + CalculateInterest());
        }
    }

    // Fixed deposit account class
    class FixedDepositTask23 : AccountTask23
    {
        private double rate = 7.0;

        // Constructor
        public FixedDepositTask23(double principal)
            : base(principal)
        {
        }

        // Implement abstract method
        public override double CalculateInterest()
        {
            return principal * rate / 100;
        }

        // Display fixed deposit information
        public void Display()
        {
            Console.WriteLine("\n--- Fixed Deposit Account ---");
            DisplayPrincipal();
            Console.WriteLine("Interest Rate: " + rate + "%");
            Console.WriteLine("Interest: " + CalculateInterest());
        }
    }

    // Test class
    class TestAccountTask23
    {
        static void Main(string[] args)
        {
            // Create Savings Account object
            SavingsAccountTask23 savings =
                new SavingsAccountTask23(10000);

            // Create Fixed Deposit object
            FixedDepositTask23 fixedDeposit =
                new FixedDepositTask23(10000);

            // Display interest details
            savings.Display();
            fixedDeposit.Display();

            Console.ReadKey();
        }
    }


}