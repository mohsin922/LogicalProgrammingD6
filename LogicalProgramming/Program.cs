using System;

namespace LogicalProgramming
{
    public class Fibonacci
    {
        /**
         * Sum of previous two integers is updated and stored in another variable
         * updated variable is used for the logic till the range of series
         */
        public void fibonacciSeries()
        {
            Console.WriteLine("Enter number up to required series : ");
            int fibRange = Convert.ToInt32(Console.ReadLine());
            int num1 = 0;
            int num2 = 1;
            int updateNum;
            for (int i = 0; i < fibRange; i++)
            {
                Console.WriteLine(num1 + " ");
                updateNum = num1 + num2;
                num1 = num2;
                num2 = updateNum;
            }
        }
        public static void Main(String[] args)
        {
            Fibonacci fibSeriesObj = new Fibonacci();
            fibSeriesObj.fibonacciSeries();
        }
    }
}
