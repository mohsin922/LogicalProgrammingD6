using System;

namespace Payment
{
    class Util
    {
        public void MonthlyPayemt(int P, int y, int R)
        {
            double n, r;
            
            
            n = 12 * y;
            r = R / (12 * 100);

            double monthpay = P * r / ( 1 - (Math.Pow ((1 + r), -n )));
            Console.WriteLine("the payment is {0}", monthpay);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the principle amount");
            int P = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter no. of  years ");
            int y = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter rate of interest");
            int R = Convert.ToInt32(Console.ReadLine());

            Util u = new Util();
            u.MonthlyPayemt(P, y, R);

            
        }
    }
}