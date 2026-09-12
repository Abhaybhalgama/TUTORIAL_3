using System;

namespace ClockApplication
{
    class Clock
    {
        // Private data members for storing time
        private int hour;
        private int min;
        private int sec;

        // No-argument constructor
        // Initializes the clock to 12:00:00
        public Clock()
        {
            hour = 12;
            min = 0;
            sec = 0;
        }

        // Three-argument constructor
        // Initializes the clock with the given time
        public Clock(int h, int m, int s)
        {
            hour = h;
            min = m;
            sec = s;
        }

        // Method to increment the time by one second
        public void IncrementTime()
        {
            sec++;

            // If seconds reach 60, reset to 0
            // and increment the minute
            if (sec == 60)
            {
                sec = 0;
                min++;
            }

            // If minutes reach 60, reset to 0
            // and increment the hour
            if (min == 60)
            {
                min = 0;
                hour++;
            }

            // If hour reaches 24, start again from 0
            if (hour == 24)
            {
                hour = 0;
            }
        }

        // Method to display the current time
        public void Display()
        {
            Console.WriteLine("{0:D2}:{1:D2}:{2:D2}", hour, min, sec);
        }

        // Method to return hour
        public int getHour()
        {
            return hour;
        }

        // Method to return minute
        public int getMinute()
        {
            return min;
        }

        // Method to return seconds
        public int getSeconds()
        {
            return sec;
        }
    }

    // Demo class
    class TestClock
    {
        static void Main(string[] args)
        {
            // Object created using no-argument constructor
            Clock c1 = new Clock();

            Console.WriteLine("Clock 1:");
            c1.Display();

            // Increment time by one second
            c1.IncrementTime();

            Console.WriteLine("After one second:");
            c1.Display();

            Console.WriteLine();

            // Object created using three-argument constructor
            Clock c2 = new Clock(11, 59, 59);

            Console.WriteLine("Clock 2:");
            c2.Display();

            // Increment 11:59:59 to 12:00:00
            c2.IncrementTime();

            Console.WriteLine("After one second:");
            c2.Display();

            Console.WriteLine();

            // Access time using getter methods
            Console.WriteLine("Hour: " + c2.getHour());
            Console.WriteLine("Minute: " + c2.getMinute());
            Console.WriteLine("Seconds: " + c2.getSeconds());

            Console.ReadKey();
        }
    }


}