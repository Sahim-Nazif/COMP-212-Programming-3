using System;

namespace Multicast_Delegate_Example
{
    class Program
    {
        public delegate double PerformCalculation(double x, double y);

        public static double Add( double a, double b)
        {
            Console.WriteLine("The result of addition is " + Math.Round(a + b));
            return (a + b);
        }
        public static double Divide(double a, double b)
        {
            Console.WriteLine("The result of division is " + a/b );
            return (a / b);
        }
        static void Main(string[] args)
        {
            PerformCalculation addition = Add;
            addition(22.44, 32.89);

            

        }
    }
}
