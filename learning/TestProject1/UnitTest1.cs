using System;

namespace DurationApp
{
    public class Duration
    {
        private int hours;
        private int minutes;
        private int seconds;

        public Duration(int hours, int minutes, int seconds)
        {
            this.hours = hours;
            this.minutes = minutes;
            this.seconds = seconds;
        }

        public Duration(int totalSeconds)
        {
            hours = totalSeconds / 3600;            
            totalSeconds %= 3600;                   
            minutes = totalSeconds / 60;            
            seconds = totalSeconds % 60;            
        }

        public void GetString()
        {
            if (hours > 0)
            {
                Console.WriteLine($"Hours: {hours}, Minutes: {minutes}, Seconds: {seconds}");
            }
            else if (minutes > 0)
            {
                Console.WriteLine($"Minutes: {minutes}, Seconds: {seconds}");
            }
            else
            {
                Console.WriteLine($"Seconds: {seconds}");
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Test Case 1
            Duration D1 = new Duration(1, 10, 15);
            D1.GetString(); 

            // Test Case 2
            Duration D2 = new Duration(3600);
            D2.GetString(); 

            // Test Case 3
            Duration D3 = new Duration(7800);
            D3.GetString(); 

            // Test Case 4
            Duration D4 = new Duration(666);
            D4.GetString(); 
        }
    }
}
