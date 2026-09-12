using System;

namespace Task8Application
{
    // Student class for storing student information
    class StudentTask8
    {
        // Private data members
        private int enrollmentNo;
        private string name;
        private int age;
        private string course;

        // Parameterized constructor
        // Initializes student details
        public StudentTask8(int enrollmentNo, string name, int age, string course)
        {
            this.enrollmentNo = enrollmentNo;
            this.name = name;
            this.age = age;
            this.course = course;
        }

        // Method to display student details
        public void DisplayDetails()
        {
            Console.WriteLine("\n--- Student Details ---");
            Console.WriteLine("Enrollment No: " + enrollmentNo);
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Age: " + age);
            Console.WriteLine("Course: " + course);
        }
    }

    // Test class containing Main method
    class TestStudentTask8
    {
        static void Main(string[] args)
        {
            // Accept student details from the user
            Console.Write("Enter Enrollment No: ");
            int enrollmentNo = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Name: ");
            string name = Console.ReadLine();

            Console.Write("Enter Age: ");
            int age = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Course: ");
            string course = Console.ReadLine();

            // Create Student object using constructor
            StudentTask8 student =
                new StudentTask8(enrollmentNo, name, age, course);

            // Call method to display details
            student.DisplayDetails();

            Console.ReadKey();
        }
    }


}