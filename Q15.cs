using System;

namespace Task15Application
{
    // Base class containing common personal information
    class PersonTask15
    {
        // Protected members can be accessed by derived classes
        protected string name;
        protected int age;
        protected string address;

        // Constructor of base class
        public PersonTask15(string name, int age, string address)
        {
            this.name = name;
            this.age = age;
            this.address = address;
        }

        // Method to display personal information
        public void DisplayPersonalDetails()
        {
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Age: " + age);
            Console.WriteLine("Address: " + address);
        }
    }

    // Student class inherits PersonTask15
    class StudentTask15 : PersonTask15
    {
        // Student-specific data members
        private int enrollmentNo;
        private string course;

        // Constructor of derived class
        public StudentTask15(
            string name,
            int age,
            string address,
            int enrollmentNo,
            string course)
            : base(name, age, address)
        {
            this.enrollmentNo = enrollmentNo;
            this.course = course;
        }

        // Method to display complete student information
        public void DisplayStudentDetails()
        {
            Console.WriteLine("\n--- Student Details ---");

            // Call inherited method
            DisplayPersonalDetails();

            // Display Student-specific information
            Console.WriteLine("Enrollment No: " + enrollmentNo);
            Console.WriteLine("Course: " + course);
        }
    }

    // Test class
    class TestStudentTask15
    {
        static void Main(string[] args)
        {
            // Create Student object
            StudentTask15 student = new StudentTask15(
                "Rahul",
                20,
                "Ahmedabad",
                101,
                "BCA"
            );

            // Display complete details
            student.DisplayStudentDetails();

            Console.ReadKey();
        }
    }


}