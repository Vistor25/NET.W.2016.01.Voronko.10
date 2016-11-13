using System;

namespace Task2
{
    public class Square:IPerimeter,IArea
    {
        public double Side { get; }

        public Square(double a)
        {
            Side = a;
        }

        public double Perimeter() => Side*4;
        public double Area() => Math.Pow(Side, 2);
    }
}