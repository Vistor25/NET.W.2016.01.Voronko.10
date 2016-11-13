using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public class Circle:IPerimeter,IArea
    {
        public double R { get; }
        
        public Circle(double r)
        {
            R = r;
        }

        public double Perimeter()
        {
            double P = 0;
            return 2*Math.PI*R;
        }

        public double Area() => Math.PI*Math.Pow(R, 2);

    }
}
