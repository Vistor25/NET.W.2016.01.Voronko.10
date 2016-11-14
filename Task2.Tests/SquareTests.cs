using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Task2.Tests
{
    [TestFixture]
    public class SquareTests
    {
        [TestCase(1, ExpectedResult = 4)]
        [TestCase(4.5, ExpectedResult = 18)]
        [TestCase(3, ExpectedResult = 12)]
        public double PerimetrTests(double a)
        {
            var square = new Square(a);

            return square.Perimeter();
        }

        [TestCase(2, ExpectedResult = 4)]
        [TestCase(4.5, ExpectedResult = 20.25)]
        [TestCase(3, ExpectedResult = 9)]
        public double AreaTests(double a)
        {
            var square = new Square(a);

            return square.Area();
        }
    }
}
