using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Demo.Common;

namespace Demo.Lib
{
    public class Second:IDemo
    {
        public void ConsoleLog()
        {
            Console.WriteLine("SECOND module loaded");
        }
    }
}
