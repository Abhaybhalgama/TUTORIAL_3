using System;

namespace Task11Application
{
    // BankAccount class represents a bank account
    class BankAccountTask11
    {
        // Private data members
        private int accountNo;
        private string accountHolder;
        private double balance;

        // Constructor to initialize account details
        public BankAccountTask11(
            int accountNo,
            string accountHolder,
            double balance)
        {
            this.accountNo = accountNo;
            this.accountHolder = accountHolder;
            this.balance = balance;
        }

        // Method to deposit money
        public void Deposit(double amount)
        {
            if (amount > 0)
            {
                balance += amount;
                Console.WriteLine("Amount deposited: " + amount);
            }
            else
            {
                Console.WriteLine("Invalid deposit amount.");
            }
        }

        // Method to withdraw money
        public void Withdraw(double amount)
        {
            if (amount <= 0)
            {
                Console.WriteLine("Invalid withdrawal amount.");
            }
            else if (amount > balance)
            {
                Console.WriteLine("Insufficient balance.");
            }
            else
            {
                balance -= amount;
                Console.WriteLine("Amount withdrawn: " + amount);
            }
        }

        // Method to display current balance
        public void CheckBalance()
        {
            Console.WriteLine("Current Balance: " + balance);
        }

        // Method to display account details
        public void DisplayAccount()
        {
            Console.WriteLine("\n--- Account Details ---");
            Console.WriteLine("Account No: " + accountNo);
            Console.WriteLine("Account Holder: " + accountHolder);
            Console.WriteLine("Balance: " + balance);
        }
    }

    // Test class
    class TestBankAccountTask11
    {
        static void Main(string[] args)
        {
            // Create first bank account
            BankAccountTask11 account1 =
                new BankAccountTask11(1001, "Rahul", 10000);

            // Create second bank account
            BankAccountTask11 account2 =
                new BankAccountTask11(1002, "Priya", 15000);

            // Display first account
            account1.DisplayAccount();

            // Deposit money into first account
            account1.Deposit(5000);

            // Withdraw money from first account
            account1.Withdraw(2000);

            // Check balance of first account
            account1.CheckBalance();

            // Display second account
            account2.DisplayAccount();

            // Deposit money into second account
            account2.Deposit(3000);

            // Withdraw money from second account
            account2.Withdraw(5000);

            // Check balance of second account
            account2.CheckBalance();

            Console.ReadKey();
        }
    }


}