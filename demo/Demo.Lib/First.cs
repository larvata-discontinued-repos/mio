using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Demo.Common;

namespace Demo.Lib
{
    public class First:IDemo
    {
        public void ConsoleLog()
        {
            Console.WriteLine("FIRST module loaded");
        }
    }
}
