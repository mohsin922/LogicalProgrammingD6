using System;
using NodaTime;

namespace LogicalProgramming
{
    public class Stopwatch
    {
        static Instant  start;
        static Instant stop;
        public static void setStart()
        {
            
            while (true)
            {
                Console.WriteLine("Enter START to start the timer : ");
                String startTime = Convert.ToString(Console.ReadLine());
                if (startTime.Equals("START"))
                {
                    start = Instant.now();
                    break;
                }
            }
        }
        
        public static void setStop()
        {
            
            while (true)
            {
                Console.WriteLine("Enter STOP to stop the timer : ");
                String stopTimer = Convert.ToString(Console.ReadLine());
                if (stopTimer.Equals("STOP"))
                {
                    stop = Instant.now;
                    break;
                }
            }
        }
        public void getTime()
        {
            setStart();
            setStop();
            long timeElapsed = Duration.between(start, stop).toMillis();
            Console.WriteLine("Timer Count : " + timeElapsed + " milliseconds");
        }
        public static void Main(String[] args)
        {
            Stopwatch stopwatchObj = new Stopwatch();
            stopwatchObj.getTime();
        }
    }
}
