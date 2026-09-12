using System;

namespace Task13Application
{
    // Product class demonstrates properties and bill calculation
    class ProductTask13
    {
        // Private data members
        private int productCode;
        private string productName;
        private double price;
        private int quantity;

        // Property for Product Code
        public int ProductCode
        {
            get { return productCode; }
            set { productCode = value; }
        }

        // Property for Product Name
        public string ProductName
        {
            get { return productName; }
            set { productName = value; }
        }

        // Property for Price
        public double Price
        {
            get { return price; }
            set { price = value; }
        }

        // Property for Quantity
        public int Quantity
        {
            get { return quantity; }
            set { quantity = value; }
        }

        // Method to calculate bill amount
        public double CalculateBill()
        {
            // Bill amount = price × quantity
            return Price * Quantity;
        }

        // Method to display product details and bill
        public void DisplayBill()
        {
            Console.WriteLine("\n--- Product Bill ---");
            Console.WriteLine("Product Code: " + ProductCode);
            Console.WriteLine("Product Name: " + ProductName);
            Console.WriteLine("Price: " + Price);
            Console.WriteLine("Quantity: " + Quantity);
            Console.WriteLine("Bill Amount: " + CalculateBill());
        }
    }

    // Test class
    class TestProductTask13
    {
        static void Main(string[] args)
        {
            // Create Product object
            ProductTask13 product = new ProductTask13();

            // Accept product details
            Console.Write("Enter Product Code: ");
            product.ProductCode =
                Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Product Name: ");
            product.ProductName = Console.ReadLine();

            Console.Write("Enter Price: ");
            product.Price =
                Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter Quantity: ");
            product.Quantity =
                Convert.ToInt32(Console.ReadLine());

            // Display product details and bill
            product.DisplayBill();

            Console.ReadKey();
        }
    }


}