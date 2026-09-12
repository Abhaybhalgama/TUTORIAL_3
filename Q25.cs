using System;

namespace Task25Application
{
    class PasswordTask25
    {
        // Method to validate the password
        public bool ValidatePassword(string password)
        {
            // Password must contain at least 8 characters
            if (password.Length < 8)
            {
                return false;
            }

            // Password must contain at least one digit
            bool hasDigit = false;

            for (int i = 0; i < password.Length; i++)
            {
                if (char.IsDigit(password[i]))
                {
                    hasDigit = true;
                    break;
                }
            }

            return hasDigit;
        }

        // Method to modify the password
        public string ModifyPassword(string password)
        {
            // Replace spaces with underscore
            string modified = password.Replace(" ", "_");

            // Convert password to uppercase
            modified = modified.ToUpper();

            return modified;
        }
    }

    class TestPasswordTask25
    {
        static void Main(string[] args)
        {
            // Create Password object
            PasswordTask25 passwordObject =
                new PasswordTask25();

            // Accept password from user
            Console.Write("Enter Password: ");
            string password = Console.ReadLine();

            // Validate password
            if (passwordObject.ValidatePassword(password))
            {
                Console.WriteLine("Password is valid.");

                // Modify password using string operations
                string modifiedPassword =
                    passwordObject.ModifyPassword(password);

                Console.WriteLine(
                    "Modified Password: " + modifiedPassword);
            }
            else
            {
                Console.WriteLine(
                    "Password is invalid.");
                Console.WriteLine(
                    "Password must have at least 8 characters and one digit.");
            }

            Console.ReadKey();
        }
    }


}