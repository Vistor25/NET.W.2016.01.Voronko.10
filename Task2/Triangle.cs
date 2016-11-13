using System;
using System.Dynamic;

namespace Task2
{
    public class Triangle:IPerimeter,IArea
    {
        public double FirstSide { get; }
        public double SecondSide { get; }
        public  double ThirdSide { get; }

        public Triangle(double a, double b, double c)
        {
            FirstSide = a;
            SecondSide = b;
            ThirdSide = c;
        }

        public double Perimeter() => FirstSide + SecondSide + ThirdSide;

        public double Area()
        {
            double p = (FirstSide + SecondSide + ThirdSide)/2;
            return Math.Sqrt(p*(p - FirstSide)*(p - SecondSide)*(p - ThirdSide));
        }
    }
}