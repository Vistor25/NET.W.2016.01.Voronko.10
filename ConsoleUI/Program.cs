using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task1;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            Timer timer = new Timer(4);
            var obj1 = new Class1();
            var obj2 = new Class2();
            timer.CountDownfinished += obj1.Write;
            timer.CountDownfinished += obj2.Write;
            timer.Start();
        }
    }
}
