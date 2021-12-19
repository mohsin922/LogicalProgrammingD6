using System;

namespace LogicalProgramming
{
    public class PerfectNumber
    {
        public void divisors()
        {
            int updateNum = 0;
            
            Console.WriteLine("Enter a number to check is perfect number or not : ");
            int number = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i < number; i++)
            {
                if (number % i == 0)
                {
                    updateNum += i;
                    Console.WriteLine(i + " ");
                }
            }
            if (updateNum == number)
            {
                Console.WriteLine("\n" + number + " = " + updateNum);
                Console.WriteLine("It is a perfect number");
            }
            else
            {
                Console.WriteLine("\n" + number + " != " + updateNum);
                Console.WriteLine("It is not a perfect number");
            }
        }
        public static void Main(String[] args)
        {
            PerfectNumber perfectNumberObj = new PerfectNumber();
            perfectNumberObj.divisors();
        }
    }
}
