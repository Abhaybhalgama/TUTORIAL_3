using System;

namespace Task17Application
{
    // Base class for shapes
    class ShapeTask17
    {
        // Virtual method that can be overridden
        public virtual double CalculateArea()
        {
            return 0;
        }
    }

    // Circle class inherits ShapeTask17
    class CircleTask17 : ShapeTask17
    {
        private double radius;

        // Constructor
        public CircleTask17(double radius)
        {
            this.radius = radius;
        }

        // Override CalculateArea for circle
        public override double CalculateArea()
        {
            return Math.PI * radius * radius;
        }
    }

    // Rectangle class inherits ShapeTask17
    class RectangleTask17 : ShapeTask17
    {
        private double length;
        private double width;

        // Constructor
        public RectangleTask17(double length, double width)
        {
            this.length = length;
            this.width = width;
        }

        // Override CalculateArea for rectangle
        public override double CalculateArea()
        {
            return length * width;
        }
    }

    // Triangle class inherits ShapeTask17
    class TriangleTask17 : ShapeTask17
    {
        private double baseLength;
        private double height;

        // Constructor
        public TriangleTask17(double baseLength, double height)
        {
            this.baseLength = baseLength;
            this.height = height;
        }

        // Override CalculateArea for triangle
        public override double CalculateArea()
        {
            return 0.5 * baseLength * height;
        }
    }

    // Test class
    class TestShapeTask17
    {
        static void Main(string[] args)
        {
            // Create Circle object
            CircleTask17 circle = new CircleTask17(5);

            // Create Rectangle object
            RectangleTask17 rectangle = new RectangleTask17(10, 5);

            // Create Triangle object
            TriangleTask17 triangle = new TriangleTask17(8, 6);

            // Display areas
            Console.WriteLine("Circle Area: " +
                              circle.CalculateArea().ToString("F2"));

            Console.WriteLine("Rectangle Area: " +
                              rectangle.CalculateArea());

            Console.WriteLine("Triangle Area: " +
                              triangle.CalculateArea());

            Console.ReadKey();
        }
    }


}