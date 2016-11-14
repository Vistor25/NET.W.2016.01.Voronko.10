using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Task2.Tests
{
    class RectangleTests
    {
        [TestFixture]
        public class SquareTests
        {
            [TestCase(1,3, ExpectedResult = 8)]
            [TestCase(2,4, ExpectedResult = 12)]
            [TestCase(3,5, ExpectedResult = 16)]
            public double PerimetrTests(double a, double b)
            {
                var rectangle = new Rectangle(a,b);

                return rectangle.Perimeter();
            }

            [TestCase(1, 3, ExpectedResult = 3)]
            [TestCase(2, 4, ExpectedResult = 8)]
            [TestCase(3, 5, ExpectedResult = 15)]
            public double AreaTests(double a, double b)
            {
                var rectangle = new Rectangle(a,b);

                return rectangle.Area();
            }

        }
    }
}
