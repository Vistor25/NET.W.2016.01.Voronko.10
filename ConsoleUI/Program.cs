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
            var obj = new Class1();
            timer.CountDownfinished += obj.Write;
            timer.Start();
        }
    }
}
