using System;

namespace Task20Application
{
    // Student class demonstrates the use of this keyword
    class StudentTask20
    {
        // Private data members
        private int enrollmentNo;
        private string name;
        private int age;

        // Constructor
        public StudentTask20(int enrollmentNo, string name, int age)
        {
            // 'this' refers to the current object's data member
            this.enrollmentNo = enrollmentNo;
            this.name = name;
            this.age = age;
        }

        // Method to display student details
        public void Display()
        {
            Console.WriteLine("--- Student Details ---");
            Console.WriteLine("Enrollment No: " + enrollmentNo);
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Age: " + age);
        }
    }

    // Test class
    class TestStudentTask20
    {
        static void Main(string[] args)
        {
            // Create Student object
            StudentTask20 student =
                new StudentTask20(101, "Rahul", 20);

            // Display student information
            student.Display();

            Console.ReadKey();
        }
    }


}