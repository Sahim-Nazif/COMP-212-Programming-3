using System;

namespace Multicast_Delegate_Example
{
    class Program
    {
        public delegate double PerformCalculation(double x, double y);

        public static double Add( double a, double b)
        {
            Console.WriteLine("The result of addition " + Math.Round(a + b));
            return (a + b);
        }
        static void Main(string[] args)
        {
           
        }
    }
}
