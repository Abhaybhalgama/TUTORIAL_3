using System;

namespace Task24Application
{
    // Sealed class cannot be inherited
    sealed class StudentResultTask24
    {
        // Private data members
        private int enrollmentNo;
        private string name;
        private double marks;

        // Constructor
        public StudentResultTask24(
            int enrollmentNo,
            string name,
            double marks)
        {
            this.enrollmentNo = enrollmentNo;
            this.name = name;
            this.marks = marks;
        }

        // Method to calculate result
        public string CalculateResult()
        {
            if (marks >= 40)
            {
                return "Pass";
            }
            else
            {
                return "Fail";
            }
        }

        // Method to display student result
        public void DisplayResult()
        {
            Console.WriteLine("\n--- Student Result ---");
            Console.WriteLine("Enrollment No: " + enrollmentNo);
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Marks: " + marks);
            Console.WriteLine("Result: " + CalculateResult());
        }
    }

    // Test class
    class TestStudentResultTask24
    {
        static void Main(string[] args)
        {
            // Create sealed class object
            StudentResultTask24 student =
                new StudentResultTask24(
                    101,
                    "Rahul",
                    78
                );

            // Display result
            student.DisplayResult();

            Console.ReadKey();
        }
    }


}