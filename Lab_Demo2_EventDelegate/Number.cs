using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_Demo2_EventDelegate
{
    //subscriber class
    public class Number
    {
        public int amount;
        private PrintHelper printHelper;
        public Number(int _amount)
        {
            amount = _amount;
            printHelper = new PrintHelper();

            //subscription to beforeEvent event
            printHelper.beforePrintEvent += PrintHelper_beforePrintEvent;
        }

        public int Amount
        {
            get { return amount; }
            set { amount = value; }
        }

        public void PrintHelper_beforePrintEvent()
        {
            Console.WriteLine("Reporting from the event handler : PrintHelper is going to print a value");
        }

        public void PrintMoney()
        {
            printHelper.PrintMoney(amount);
        }
        public void PrintNumber()
        {
            printHelper.PrintNumber(amount);
        }
    }
}
