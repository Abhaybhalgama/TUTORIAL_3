using System;

namespace Task9Application
{
    // Clock class stores and manages time
    class ClockTask9
    {
        // Private data members
        private int hour;
        private int minute;
        private int second;

        // Parameterized constructor
        // Initializes the clock with the given time
        public ClockTask9(int hour, int minute, int second)
        {
            this.hour = hour;
            this.minute = minute;
            this.second = second;
        }

        // Method to display the current time
        public void DisplayTime()
        {
            Console.WriteLine("{0:D2}:{1:D2}:{2:D2}",
                hour, minute, second);
        }

        // Method to increment the time by one second
        public void IncrementSecond()
        {
            second++;

            // When seconds reach 60, reset and increase minute
            if (second == 60)
            {
                second = 0;
                minute++;
            }

            // When minutes reach 60, reset and increase hour
            if (minute == 60)
            {
                minute = 0;
                hour++;
            }

            // When hour reaches 24, start from 00
            if (hour == 24)
            {
                hour = 0;
            }
        }
    }

    // Test class
    class TestClockTask9
    {
        static void Main(string[] args)
        {
            // Create clock object with initial time
            ClockTask9 clock = new ClockTask9(11, 59, 59);

            // Display original time
            Console.WriteLine("Current Time:");
            clock.DisplayTime();

            // Increment time by one second
            clock.IncrementSecond();

            // Display updated time
            Console.WriteLine("After Incrementing One Second:");
            clock.DisplayTime();

            Console.ReadKey();
        }
    }


}