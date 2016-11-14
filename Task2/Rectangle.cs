using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public class Rectangle : IPerimeter, IArea
    {
        public double Aside { get; }
        public double Bside { get; }

        public Rectangle(double a, double b)
        {
            Aside = a;
            Bside = b;
        }

        public double Area() => Aside*Bside;


        public double Perimeter() => (Aside + Bside)*2;
    }
}