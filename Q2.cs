//2 : Define a class Clock with three private integer data members
//    hour, min and sec. Define a no argument constructor to initialize time value to 12:00:00.Define a three
//    argument constructor to initialize the time.
//Define a methods to

//Increment time to next second.
//Display the time value.
//Return the hour (int getHour())
//Return the minute (int getMinute())
//Return the seconds (int getSeconds())
using System;

class Clock
{
    int hour, min, sec;

    public Clock()
    {
        hour = 12;
        min = 0;
        sec = 0;
    }

    public Clock(int h, int m, int s)
    {
        hour = h;
        min = m;
        sec = s;
    }

    // Increment to next second
    public void IncrementTime()
    {
        sec++;

        if (sec == 60)
        {
            sec = 0;
            min++;
        }

        if (min == 60)
        {
            min = 0;
            hour++;
        }

        if (hour == 24)
        {
            hour = 0;
        }
    }

    public void Display()
    {
        Console.WriteLine(hour + ":" + min + ":" + sec);
    }

    public int getHour()
    {
        return hour;
    }

    public int getMinute()
    {
        return min;
    }

    public int getSeconds()
    {
        return sec;
    }
}

class TestClock
{
    static void Main()
    {
        // Create object
        Clock c = new Clock(10, 59, 59);

        Console.WriteLine("Current Time:");
        c.Display();

        // Increment time                                                      
        c.IncrementTime();

        Console.WriteLine("After Increment:");
        c.Display();

        // Getter methods
        Console.WriteLine("Hour : " + c.getHour());
        Console.WriteLine("Minute : " + c.getMinute());
        Console.WriteLine("Second : " + c.getSeconds());

        Console.ReadLine();
    }
}