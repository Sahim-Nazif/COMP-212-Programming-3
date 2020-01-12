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
            //instantiation, creation of delegate objects
            GreetingDelegate firstDel, secondDel;
            //registeration
            firstDel = new GreetingDelegate(Hello);
            secondDel = new GreetingDelegate(Goodbye);

            //calling methods via the delegate
            firstDel("Nazif");
            secondDel("Sahim");

            //second way of instantiation
            //firstDel=Hello;
            //SecondDel=GoodBye;

            //Multicasting Delegate

            firstDel += secondDel;

            //passing delegate to a method
            GreetingMethod(firstDel, "Nazif Sahim");

        }
        //passing delegate as parameter to a method
        public static void GreetingMethod(GreetingDelegate greetingDelegate, string name)
        {
            Console.WriteLine("The greeting is ");
            greetingDelegate(name);
        }
    }
}
