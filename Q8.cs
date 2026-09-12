//8. A program to accept and display student details using a class, objects, constructors, and methods.

using System;

namespace Lab3
{
    class Student                                       //8
    {
        private int enrollmentNo;
        private string name;
        private string course;

        // Parameterized Constructor
        public Student(int eno, string nm, string crs)
        {
            enrollmentNo = eno;
            name = nm;
            course = crs;
        }

        // Display Method
        public void Display()
        {
            Console.WriteLine("\nStudent Details");
            Console.WriteLine("Enrollment No : " + enrollmentNo);
            Console.WriteLine("Name          : " + name);
            Console.WriteLine("Course        : " + course);
        }
    }
    class Pro8
    {
        static void Main()
        {
            Console.Write("Enter Enrollment No: ");
            int eno = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Name: ");
            string name = Console.ReadLine();

            Console.Write("Enter Course: ");
            string course = Console.ReadLine();

            Student s = new Student(eno, name, course);

            s.Display();

            Console.Read();
        }
    }
}


