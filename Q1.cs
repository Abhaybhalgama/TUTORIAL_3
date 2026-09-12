using System;

namespace ClassObjectDemo
{
    // Task 1: Create a class named Student
    class Student
    {
        // Task 2: Private data members
        private int rollNo;
        private string name;

        // Task 3: Public method to assign values
        public void SetData(int r, string n)
        {
            // Store the values in private data members
            rollNo = r;
            name = n;
        }

        // Task 3: Public method to display student details
        public void Display()
        {
            Console.WriteLine("Roll No: " + rollNo);
            Console.WriteLine("Name: " + name);
        }
    }

    // Task 4: Demo class containing Main method
    class Demo
    {
        static void Main(string[] args)
        {
            // Task 5: Create first object of Student class
            Student s1 = new Student();

            // Set data using the first object
            s1.SetData(101, "Rahul");

            // Call Display() method using first object
            Console.WriteLine("Student 1:");
            s1.Display();

            Console.WriteLine();

            // Task 5: Create second object of Student class
            Student s2 = new Student();

            // Set data using the second object
            s2.SetData(102, "Priya");

            // Call Display() method using second object
            Console.WriteLine("Student 2:");
            s2.Display();

            Console.ReadKey();
        }
    }


}