//15.A program to inherit personal information into a student class and display complete details.


using System;

class Person
{
    public string Name;
    public int Age;
    public string Address;

    public Person(string name, int age, string address)
    {
        Name = name;
        Age = age;
        Address = address;
    }
}

class Student : Person
{
    public int RollNo;
    public string Course;

    public Student(string name, int age, string address, int rollNo, string course)
        : base(name, age, address)
    {
        RollNo = rollNo;
        Course = course;
    }

    public void DisplayDetails()
    {
        Console.WriteLine("Name    : " + Name);
        Console.WriteLine("Age     : " + Age);
        Console.WriteLine("Address : " + Address);
        Console.WriteLine("Roll No : " + RollNo);
        Console.WriteLine("Course  : " + Course);
    }
}

class Program
{
    static void Main()
    {
        Student s = new Student("Rahul", 20, "Rajkot", 101, "BCA");

        s.DisplayDetails();
    }
}
