using System;

namespace Task22Application
{
    // Base class
    class UserTask22
    {
        // Base class method
        public void DisplayInfo()
        {
            Console.WriteLine("User Information");
            Console.WriteLine("Name: Rahul");
            Console.WriteLine("Role: User");
        }
    }

    // Derived class
    class StudentTask22 : UserTask22
    {
        // 'new' hides the base class DisplayInfo() method
        public new void DisplayInfo()
        {
            Console.WriteLine("Student Information");
            Console.WriteLine("Name: Rahul");
            Console.WriteLine("Enrollment No: 101");
            Console.WriteLine("Course: BCA");
        }
    }

    // Test class
    class TestUserTask22
    {
        static void Main(string[] args)
        {
            // Create Student object
            StudentTask22 student = new StudentTask22();

            // Calls the hidden method from StudentTask22
            student.DisplayInfo();

            Console.ReadKey();
        }
    }


}