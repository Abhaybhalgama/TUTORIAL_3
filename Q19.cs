using System;

namespace Task19Application
{
    // Student class
    class StudentTask19
    {
        // Static variable shared by all objects
        private static int studentCount = 0;

        // Instance data members
        private int enrollmentNo;
        private string name;

        // Constructor
        // Runs whenever a new Student object is created
        public StudentTask19(int enrollmentNo, string name)
        {
            this.enrollmentNo = enrollmentNo;
            this.name = name;

            // Increase static count for every new object
            studentCount++;
        }

        // Method to display student details
        public void Display()
        {
            Console.WriteLine(
                "Enrollment No: " + enrollmentNo +
                ", Name: " + name);
        }

        // Static method to return total student count
        public static int GetStudentCount()
        {
            return studentCount;
        }
    }

    // Test class
    class TestStudentTask19
    {
        static void Main(string[] args)
        {
            // Create first student object
            StudentTask19 s1 =
                new StudentTask19(101, "Rahul");

            // Create second student object
            StudentTask19 s2 =
                new StudentTask19(102, "Priya");

            // Create third student object
            StudentTask19 s3 =
                new StudentTask19(103, "Amit");

            // Display student details
            s1.Display();
            s2.Display();
            s3.Display();

            // Access static method using class name
            Console.WriteLine(
                "\nTotal Students Created: " +
                StudentTask19.GetStudentCount());

            Console.ReadKey();
        }
    }


}