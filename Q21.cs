using System;

namespace Task21Application
{
    // Base class
    class PersonTask21
    {
        // Data members of base class
        protected string name;
        protected int age;

        // Base class constructor
        public PersonTask21(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        // Method to display personal information
        public void DisplayPerson()
        {
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Age: " + age);
        }
    }

    // Derived class
    class StudentTask21 : PersonTask21
    {
        // Student-specific data member
        private int enrollmentNo;

        // Derived class constructor
        public StudentTask21(
            string name,
            int age,
            int enrollmentNo)
            : base(name, age)   // Calling base class constructor
        {
            this.enrollmentNo = enrollmentNo;
        }

        // Method to display complete student information
        public void DisplayStudent()
        {
            Console.WriteLine("--- Student Details ---");

            // Display inherited data
            DisplayPerson();

            // Display student-specific data
            Console.WriteLine("Enrollment No: " + enrollmentNo);
        }
    }

    // Test class
    class TestStudentTask21
    {
        static void Main(string[] args)
        {
            // Create Student object
            StudentTask21 student =
                new StudentTask21("Rahul", 20, 101);

            // Display complete details
            student.DisplayStudent();

            Console.ReadKey();
        }
    }


}