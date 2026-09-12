using System;

namespace LineApplication
{
    class Line
    {
        // Private data member to store length
        private double length;

        // Constructor
        public Line()
        {
            // Missing statement-1:
            // Initialize length to 10
            length = 10;

            // Missing statement-2:
            // Display message when object is created
            Console.WriteLine("Object is being created, length = {0}", length);
        }

        // Method to set the length
        public void setLength(double len)
        {
            // Missing statement-3:
            // Store the given value in length
            length = len;
        }

        // Method to get the length
        public double getLength()
        {
            // Missing statement-4:
            // Return the current length
            return length;
        }
    }

    class TestLine
    {
        static void Main(string[] args)
        {
            // Create Line object
            Line line = new Line();

            // Display initial length
            Console.WriteLine("Length of line : {0}", line.getLength());

            // Change length to 6
            line.setLength(6);

            // Display updated length
            Console.WriteLine("Length of line : {0}", line.getLength());

            Console.ReadKey();
        }
    }


}