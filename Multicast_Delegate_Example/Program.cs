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
            PerformCalculation division = Divide;
            division(55.33, 22.30);

            //instead of doing the above we can use Multi Cast delegate, i.e
            PerformCalculation multiCal = addition + division;

            multiCal(44.23, 22.31);

            //we can also do the following 
            multiCal -=division;
            multiCal += addition;





            

        }
    }
}
