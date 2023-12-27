namespace FactorialCalculator.Tests
{
    [TestClass]
    public class FactorialTests
    {
        [TestMethod]
        public void ZeroFactorial()
        {
            var calc = new FactorialCalculator();

            var result = calc.Calculate(0);

            Assert.AreEqual<ulong>(1, result);
        }

        [TestMethod]

        public void TwoFactorial()
        {

            var calc = new FactorialCalculator();

            var result = calc.Calculate(3);

            Assert.AreEqual<ulong>(6, result);
        }
    }

       
}