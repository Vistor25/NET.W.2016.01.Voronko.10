using System;

namespace ConsoleUI
{
    public class Class1
    {
        public void Write(string str)
        {
            if (!ReferenceEquals(str, null))
            {
                Console.WriteLine("First class");
            } 
        }
    }
}