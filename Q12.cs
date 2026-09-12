using System;

namespace Task12Application
{
    // Student class demonstrates get/set properties
    class StudentTask12
    {
        // Private data members
        private int enrollmentNo;
        private string name;

        // Property for Enrollment Number
        public int EnrollmentNo
        {
            get
            {
                return enrollmentNo;
            }
            set
            {
                enrollmentNo = value;
            }
        }

        // Property for Student Name
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        // Method to display student details
        public void Display()
        {
            Console.WriteLine("\n--- Student Details ---");
            Console.WriteLine("Enrollment No: " + EnrollmentNo);
            Console.WriteLine("Name: " + Name);
        }
    }

    // Test class
    class TestStudentTask12
    {
        static void Main(string[] args)
        {
            // Create Student object
            StudentTask12 student = new StudentTask12();

            // Accept enrollment number
            Console.Write("Enter Enrollment No: ");
            student.EnrollmentNo =
                Convert.ToInt32(Console.ReadLine());

            // Accept student name
            Console.Write("Enter Name: ");
            student.Name = Console.ReadLine();

            // Display student information
            student.Display();

            Console.ReadKey();
        }
    }


}