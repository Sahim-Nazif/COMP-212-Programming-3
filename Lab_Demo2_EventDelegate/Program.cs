﻿using System;

namespace Lab_Demo2_EventDelegate
{
    class Program
    {
        static void Main(string[] args)
        {

            Number number = new Number(1000000);
            number.PrintMoney();
            number.PrintNumber();
            Console.ReadKey();
           
        }
    }
}
