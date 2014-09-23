using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Demo.Common;

namespace Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            var bar = Mio.ProxyFactory.Create<IDemo>();
            bar.ConsoleLog();
            Console.Read();
        }
    }
}
