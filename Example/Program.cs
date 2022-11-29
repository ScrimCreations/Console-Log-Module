using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using ConsoleLog_Module;

namespace Example
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Test.Initialize();
            Thread.Sleep(-1);
        }
    }
}
