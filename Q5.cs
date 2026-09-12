using System;

namespace ConsoleApplication
{
    class Product
    {
        // Data members of Product class
        private string pcode;
        private string pname;
        private string mname;

        // Constructor to initialize product details
        public Product(string pcd, string pnm, string mnm)
        {
            pcode = pcd;
            pname = pnm;
            mname = mnm;
        }

        // Method to display product details
        public void Display()
        {
            Console.WriteLine("Product Code:= " + pcode);
            Console.WriteLine("Product Name:= " + pname);
            Console.WriteLine("Manufacturer Name:= " + mname);
        }
    }

    // TestProduct class containing Main method
    public class TestProduct
    {
        public static void Main(string[] args)
        {
            // Check whether three command-line arguments are provided
            int n = args.Length;

            if (n < 3)
            {
                Console.WriteLine("Syntax Error\n");
                Console.WriteLine("Must Have THREE Arguments\n");
                Console.WriteLine("Please, Write as [csc TestProduct ProductCode ProductName Manufacturer]");
            }
            else
            {
                // Read product details from command-line arguments
                string pcd = args[0];
                string pnm = args[1];
                string mnm = args[2];

                // Create Product object using constructor
                Product p = new Product(pcd, pnm, mnm);

                // Display product details
                p.Display();

                Console.ReadKey();
            }
        }
    }


}