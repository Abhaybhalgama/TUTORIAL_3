
using System;

namespace StudentDemo
{

    class Student1
    {
        public int RollNo;
        public string Name;

        public Student1()
        {
            RollNo = 0;
            Name = "Unknown";
        }

        public Student1(int r, string n)
        {
            RollNo = r;
            Name = n;
        }

        public void Display()
        {
            Console.WriteLine("Roll No : " + RollNo);
            Console.WriteLine("Name    : " + Name);
        }
    }

    class TestStudent1
    {
        static void Main()
        {
            Student s1 = new Student(101, "Rahul");
            Student s2 = new Student(102, "Rajesh");
            Student s3 = new Student(103, "Ritesh");
            Student s4 = new Student(104, "Rakesh");
            Student s5 = new Student(105, "Raj");

            s1.Display();
            s2.Display();
            s3.Display();
            s4.Display();
            s5.Display();

            Console.ReadLine();
        }
    }
}