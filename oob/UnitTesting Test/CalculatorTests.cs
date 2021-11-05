using NUnit.Framework;
using UnitTesting;

namespace UnitTesting_Test
{
    [TestFixture]
    class CalculatorTests
    {
        [Test]
        public void Add_WhenCalled_ReturnTheSumOfArguments()
        {
            Calculator cal = new Calculator();

            var actualResult = cal.Add(1, 2);
            var expectedResult = 3;

            Assert.AreEqual(expectedResult, actualResult);
        }
        
        [Test]
        [TestCase(2, 2, 2)]
        [TestCase(2, 1, 3)]
        [TestCase(1, 2, 2)]

        
    }
}