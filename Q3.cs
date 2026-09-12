using System;

namespace StudentApplication
{
    // Student class
    class Student
    {
        // Private data members
        private int enrollmentNo;
        private string name;
        private int age;
        private string course;

        // Default constructor
        // Initializes student with default values
        public Student()
        {
            enrollmentNo = 0;
            name = "Unknown";
            age = 0;
            course = "Not Assigned";
        }

        // Parameterized constructor
        // Initializes student with given values
        public Student(int enrollmentNo, string name, int age, string course)
        {
            this.enrollmentNo = enrollmentNo;
            this.name = name;
            this.age = age;
            this.course = course;
        }

        // Properties for accessing private data members
        public int EnrollmentNo
        {
            get { return enrollmentNo; }
            set { enrollmentNo = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        public string Course
        {
            get { return course; }
            set { course = value; }
        }

        // Method to display student details
        public void Display()
        {
            Console.WriteLine("Enrollment No: " + enrollmentNo);
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Age: " + age);
            Console.WriteLine("Course: " + course);
        }
    }

    // TestStudent class demonstrates Student class
    class TestStudent1
    {
        static void Main()
        {
            // Create an object using the default constructor
            Student s1 = new Student();

            // Assign values using properties
            s1.EnrollmentNo = 101;
            s1.Name = "Rahul";
            s1.Age = 20;
            s1.Course = "BCA";

            Console.WriteLine("Student 1:");
            s1.Display();

            Console.WriteLine();

            // Create another object using parameterized constructor
            Student s2 = new Student(102, "Priya", 21, "MCA");

            Console.WriteLine("Student 2:");
            s2.Display();

            Console.ReadKey();
        }
    }


}