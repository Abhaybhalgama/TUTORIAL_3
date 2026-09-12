using System;

namespace Task7Application
{
    // StudentTask7 class demonstrates properties
    class StudentTask7
    {
        // Private data members
        private int enrollmentNo;
        private string name;
        private int age;
        private string course;

        // Default constructor
        public StudentTask7()
        {
            enrollmentNo = 0;
            name = "Unknown";
            age = 0;
            course = "Not Assigned";
        }

        // Parameterized constructor
        public StudentTask7(int enrollmentNo, string name, int age, string course)
        {
            this.enrollmentNo = enrollmentNo;
            this.name = name;
            this.age = age;
            this.course = course;
        }

        // Property for EnrollmentNo
        public int EnrollmentNo
        {
            get { return enrollmentNo; }
            set { enrollmentNo = value; }
        }

        // Property for Name
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        // Method to display student details
        public void Display()
        {
            Console.WriteLine("Enrollment No: " + EnrollmentNo);
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Age: " + age);
            Console.WriteLine("Course: " + course);
        }
    }

    // Separate test class for Task 7
    class TestStudentTask7
    {
        static void Main(string[] args)
        {
            // Create object using parameterized constructor
            StudentTask7 student7 =
                new StudentTask7(101, "Rahul", 20, "BCA");

            Console.WriteLine("Student Details:");
            student7.Display();

            Console.WriteLine();

            // Change EnrollmentNo and Name using properties
            student7.EnrollmentNo = 105;
            student7.Name = "Amit";

            Console.WriteLine("After Changing Properties:");
            Console.WriteLine("Enrollment No: " + student7.EnrollmentNo);
            Console.WriteLine("Name: " + student7.Name);

            Console.ReadKey();
        }
    }


}