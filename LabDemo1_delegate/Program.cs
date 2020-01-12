using System;

namespace LabDemo1_delegate
{
    //delegate declaration
    delegate void GreetingDelegate(string name);
    class Program
    {
        //method declaration
        public static void Hello(string name)
        {
            Console.WriteLine("Hello, {0}", name);
        }
        public static void Goodbye(string name)
        {
            Console.WriteLine("Bye, {0}", name);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
