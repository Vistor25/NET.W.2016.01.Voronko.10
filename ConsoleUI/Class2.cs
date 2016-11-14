using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    class Class2
    {
        public void Write(string str)
        {
            if (!ReferenceEquals(str, null))
            {
                Console.WriteLine("Second class");
            }
        }
    }
}
