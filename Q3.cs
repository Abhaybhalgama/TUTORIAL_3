//3 : Define a Student class with appropriate data members, property,
//    constructors, methos etc. Define another class called TestStudent within 
//    the same .cs file. Also create an object of student class and demonstrate the use of student class.



using System;

namespace StudentDemo
{

    class Student
    {
        public int RollNo;
        public string Name;

        public Student()
        {
            RollNo = 0;
            Name = "Unknown";
        }

        public Student(int r, string n)
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

    class TestStudent
    {
        static void Main()
        {
            Student s1 = new Student(101, "Rahul");

            s1.Display();

            Console.ReadLine();
        }
    }
}