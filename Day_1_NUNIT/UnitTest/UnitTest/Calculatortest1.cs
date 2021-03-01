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
    class Calculatortest1
    {
        CalcMethods calcMethods;

        [SetUp]
        public void Init()
        {
            calcMethods = new CalcMethods();
        }

        [TestCase(10, 5, 15)]
        [TestCase(0, 5, 5)]
        [TestCase(-5, 5, 0)]
        [TestCase(-5, -5, -10)]
        public void testAdd(int a,int b, int expected)
        {
            int actual = calcMethods.Add(a,b);
            Assert.That(actual,Is.EqualTo(expected));
        }

        [TearDown]

        public void CleanUp()
        {
            calcMethods.AllClear();
        }
    }
}
