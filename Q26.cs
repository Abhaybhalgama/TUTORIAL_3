using System;

namespace Task26Application
{
    class CustomerTask26
    {
        // Private data member for customer name
        private string customerName;

        // Constructor to initialize customer name
        public CustomerTask26(string customerName)
        {
            this.customerName = customerName;
        }

        // Method to format the customer name
        public void FormatName()
        {
            // Remove extra spaces from beginning and end
            string formattedName = customerName.Trim();

            // Replace multiple spaces with a single space
            formattedName = formattedName.Replace("  ", " ");

            // Convert name to lowercase first
            formattedName = formattedName.ToLower();

            // Convert first character to uppercase
            if (formattedName.Length > 0)
            {
                formattedName =
                    char.ToUpper(formattedName[0]) +
                    formattedName.Substring(1);
            }

            // Insert a title before the customer name
            formattedName = formattedName.Insert(0, "Mr. ");

            // Display formatted name
            Console.WriteLine("\nFormatted Customer Name: "
                              + formattedName);

            // Display uppercase version
            Console.WriteLine("Uppercase Name: "
                              + formattedName.ToUpper());

            // Display lowercase version
            Console.WriteLine("Lowercase Name: "
                              + formattedName.ToLower());
        }
    }

    // Test class
    class TestCustomerTask26
    {
        static void Main(string[] args)
        {
            // Accept customer name
            Console.Write("Enter Customer Name: ");
            string name = Console.ReadLine();

            // Create Customer object
            CustomerTask26 customer =
                new CustomerTask26(name);

            // Format and display the name
            customer.FormatName();

            Console.ReadKey();
        }
    }


}