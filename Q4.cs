using System;

namespace StudentApplication
{
    // Student class
    class Student1
    {
        // Private data members
        private int enrollmentNo;
        private string name;
        private int age;
        private string course;

        // Parameterized constructor
        public Student1(int enrollmentNo, string name, int age, string course)
        {
            // 'this' refers to the current object's data members
            this.enrollmentNo = enrollmentNo;
            this.name = name;
            this.age = age;
            this.course = course;
        }

        // Method to display student details
        public void Display()
        {
            Console.WriteLine("Enrollment No: " + enrollmentNo);
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Age: " + age);
            Console.WriteLine("Course: " + course);
            Console.WriteLine("-------------------------");
        }
    }

    // TestStudent class
    class TestStudent
    {
        static void Main(string[] args)
        {
            // Creating five Student objects
            Student s1 = new Student(101, "Rahul", 20, "BCA");
            Student s2 = new Student(102, "Priya", 21, "MCA");
            Student s3 = new Student(103, "Amit", 20, "BSc IT");
            Student s4 = new Student(104, "Neha", 22, "BCA");
            Student s5 = new Student(105, "Karan", 21, "MCA");

            // Display details of all five students
            Console.WriteLine("STUDENT DETAILS");
            Console.WriteLine("=========================");

            s1.Display();
            s2.Display();
            s3.Display();
            s4.Display();
            s5.Display();

            Console.ReadKey();
        }
    }


}