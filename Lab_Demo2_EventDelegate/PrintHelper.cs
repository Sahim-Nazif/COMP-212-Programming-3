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

    }
}
