using NUnit.Framework;

namespace TestDojoUnit
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestFactorial()
        {
            int result = Calculator.Factorial(9);
            Assert.AreEqual(362880, result);
        }

        [Test]
        public void TestFibonacci()
        {
            int result = Calculator.Fibonacci(5);
            Assert.AreEqual(5, result);
            int resultr = Calculator.Fibonacci(11);
            Assert.AreEqual(89, result);
        }
    }
}