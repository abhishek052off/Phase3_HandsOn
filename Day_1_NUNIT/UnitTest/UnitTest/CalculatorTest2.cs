using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CalcLibrary;

namespace UnitTest
{
    [TestFixture]
    class CalculatorTest2

    {
        CalcMethods calcMethods;

        [SetUp]
        public void Init()
        {
            calcMethods = new CalcMethods();
        }

        [TestCase(10, 5, 5)]
        [TestCase(0, 5, -5)]
        [TestCase(-5, 5, -10)]
        [TestCase(-5, -5,0)]
        public void TestSub(int a, int b, int expected)
        {
            int actual = calcMethods.Sub(a, b);
            Assert.AreEqual(expected,actual);
        }

        [TestCase(10, 5, 50)]
        [TestCase(0, 5, 0)]
        [TestCase(-5, 5, -25)]
        [TestCase(-5, -5, 25)]
     
        public void TestMul(int a, int b, int expected)
        {
            int actual = calcMethods.Mul(a, b);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(10, 5, 2)]
        [TestCase(0, 5, 0)]
        [TestCase(-5, 5, -1)]
        [TestCase(-5, -5, 1)]
        [TestCase(10,5,2)]
        public void TestDiv(int a, int b, int expected)
        {
            try
            {
                int actual = calcMethods.Div(a, b);
                Assert.AreEqual(expected, actual);
            }
            catch(ArgumentException)
            {
                Assert.Fail("Divisio By Zero Not Possible");
            }
            
        }

        public void TestAddAndClear()
        {
            calcMethods.Add(20, 30);
            int actual = calcMethods.Result;
            int expected = 50;
            Assert.AreEqual(actual, expected);
            calcMethods.AllClear();
            actual = calcMethods.Result;
            Assert.AreEqual(actual, 0);
        }

    }
}
