using System;

namespace LogicalProgramming
{

    public class ReverseNumber
    {
        /**
         * reverse method is used to reverse the number by modulo operator
         * remainder is stored and used in next iteration
         */
        public void reverse()
        {
            int digit;
            int reverse = 0;
            Console.WriteLine("Enter a number to reverse : ");
            int number = Convert.ToInt32(Console.ReadLine());
            while (number > 0)
            {
                digit = number % 10;
                number = number / 10;
                reverse = reverse * 10 + digit;
            }
            Console.WriteLine(reverse);
        }
        public static void Main(String[] args)
        {
            ReverseNumber reverseNumberObj = new ReverseNumber();
            reverseNumberObj.reverse();
        }
    }
}
