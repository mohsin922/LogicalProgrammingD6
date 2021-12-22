using System;
using System.Collections.Generic;


namespace LogicalProgramming
{
    class TemperatureConvertor
    {
        public void Fah(double C)
        {
            double F;
            F = (C * 1.8) + 32;
            Console.WriteLine("temperature in Fahrenheit:{0}", F);
        }
        public void Cel(double FH)
        {
            double Ce;
            Ce = ((FH - 32)*5/9 );
            Console.WriteLine("Temperature in Celsius : {0}", Ce);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter temperature in deg C to get in Fahrenheit ");
            double C = Convert.ToDouble(Console.ReadLine());
            TemperatureConvertor u = new TemperatureConvertor();
            u.Fah(C);

            Console.WriteLine("Enter temperature in deg F to get in Celsius");
            double FH = Convert.ToDouble(Console.ReadLine());
            TemperatureConvertor s = new TemperatureConvertor();
            s.Cel(FH);
        }
    }
}
