using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Task2.Tests
{
    class CircleTests
    {
        [TestFixture]
        public class SquareTests
        {
            [TestCase(1, ExpectedResult = 2*Math.PI)]
            [TestCase(2, ExpectedResult = 2 * Math.PI*2)]
            [TestCase(3, ExpectedResult = 2 * Math.PI*3)]
            public double PerimetrTests(double a)
            {
                var circle = new Circle(a);

                return circle.Perimeter();
            }

            [TestCase(1, ExpectedResult = Math.PI)]
            [TestCase(2, ExpectedResult = 4* Math.PI)]
            [TestCase(3, ExpectedResult = 9* Math.PI)]
            public double AreaTests(double a)
            {
                var circle = new Circle(a);

                return circle.Area();
            }

        }
    }
}
