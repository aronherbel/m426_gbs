namespace StringCalculator.Tests
{
    [TestClass]
    public class StringCalculatorTests
    {
        [TestMethod]
        public void ZeroString()
        {
            var calc = new StringCalculator();

            var result = calc.Add("");

            Assert.AreEqual<int>(0, result);
        }

        [TestMethod]
        public void OneString()
        {
            var calc = new StringCalculator();

            var result = calc.Add("7");

            Assert.AreEqual<int>(7, result);
        }

        [TestMethod]
        public void TwoStrings()
        {
            var calc = new StringCalculator();

            var result = calc.Add("1,4");

            Assert.AreEqual<int>(5, result);
        }

        [TestMethod]
        public void ThreeStrings()
        {
            var calc = new StringCalculator();

            var result = calc.Add("7,8,3");

            Assert.AreEqual<int>(18, result);
        }

        [TestMethod]
        public void TenStrings()
        {
            var calc = new StringCalculator();

            var result = calc.Add("1,2,3,4,5,6,7,8,9,10");

            Assert.AreEqual<int>(55, result);
        }

        [TestMethod]
        public void backslashNStrings()
        {
            var calc = new StringCalculator();

            var result = calc.Add("1\n2,3");

            Assert.AreEqual<int>(6, result);
        }

        [TestMethod]
        
        public void differentDelimetersStrings()
        {
            var calc = new StringCalculator();

            var result = calc.Add("1\n2,3,4.5&6:7/8;9|10");
            
            Assert.AreEqual(55, result);
        }

        [TestMethod]

        public void negativeStrings()
        {
            var calc = new StringCalculator();

            var ex = Assert.ThrowsException<InvalidOperationException>(() => calc.Add("-1,3,-2"));

            Assert.AreEqual("Negatives not allowed: -1, -2", ex.Message);
        }

        [TestMethod]
        public void morethen1000()
        {
            // Arrange
            var calc = new StringCalculator();

            // Act
            var result = calc.Add("2, 1001, 1000");

            // Assert
            Assert.AreEqual(1002, result);
        }

        [TestMethod]
        public void CalledCount_Check()
        {
            // Arrange
            var calc = new StringCalculator();

            // Act
            calc.Add("1,2,3");
            calc.Add("4,5,6");
            calc.Add("4,5,6");

            // Assert
            Assert.AreEqual(3, calc.CalledCount);
        }
    }
}