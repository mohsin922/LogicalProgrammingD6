using System;

namespace LogicalProgramming
{

    public class PrimeNumber
    {
        /**
         * primeNumber is a method to check it is a prime number or not
         * divide the number with all the previous numbers to check
         * 0 and 1 are not included in the loop
         */
        public void primeNumber()
        {
            Boolean isPrime = true;
            Console.WriteLine("Enter a number to check it is a prime number or not : ");
            int primeCheck = Convert.ToInt32(Console.ReadLine());
            for (int i = 2; i < primeCheck; i++)
            {
                if (primeCheck % i == 0)
                {
                    Console.WriteLine(primeCheck + " is not a prime number");
                    isPrime = false;
                    break;
                }
            }
            if (primeCheck == 0)
            {
                Console.WriteLine(primeCheck + " is not a valid number");
            }
            else if (primeCheck == 1)
            {
                Console.WriteLine(primeCheck + " is neither prime nor composite number");
            }
            else if (isPrime)
            {
                Console.WriteLine(primeCheck + " is a prime number");
            }
        }
        public static void Main(String[] args)
        {
            PrimeNumber primeNumberObj = new PrimeNumber();
            primeNumberObj.primeNumber();
        }
    }
}
