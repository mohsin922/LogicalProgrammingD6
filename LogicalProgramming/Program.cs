using System;

namespace LogicalProgramming
{

    public class CouponNumber
    {
        
        static int input;

        public static void Main(String[] args)
        {
            userInput();
            distinctCoupon(input);
        }

        public static void userInput()
        {
            Console.WriteLine("Enter how many unique Coupons do you want");

            input = Convert.ToInt32(Console.ReadLine());
        }

        public static void generateCoupons()
        {
            Random rand = new Random();
            double num = rand.NextDouble();
            double coupon = Math.Floor(num * 1000000);
            Console.WriteLine((int)coupon);
        }

        public static void distinctCoupon(int a)
        {
           Console.WriteLine("Unique Coupons are :- ");
            while (a > 0)
            {
                generateCoupons();
                a--;
            }
        }
    }

}
