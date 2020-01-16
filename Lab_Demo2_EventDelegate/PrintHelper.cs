using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_Demo2_EventDelegate
{
    //this is the publisher class
    public class PrintHelper
    {
        //declaring delegate
        public delegate void BeforePrint();
        //declaring event of type delegate (BeforePrint)

        public event BeforePrint beforePrintEvent;

        public PrintHelper()
        {

        }

        public void PrintNumber (int num)
        {
            if (beforePrintEvent != null)
                beforePrintEvent.Invoke();

            Console.WriteLine("Number : " + num);

        }
        public void PrintMoney (int amount)
        {
            if (beforePrintEvent != null)
                beforePrintEvent.Invoke();

            Console.WriteLine("The Amount is : " + amount);

        }

    }
}
