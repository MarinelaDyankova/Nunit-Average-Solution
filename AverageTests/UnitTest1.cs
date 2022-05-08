using NUnit.Framework;

namespace AverageTests
{
    public class Tests
    {
        
        [Test]
        public void Test_AverageTwoNumbers()
        {
            double avr = Average.Average.AverageNumbers(new double[] { 6, 8 });
            Assert.AreEqual(7.00, avr);
        }

        [Test]
        public void Test_AverageThreeNumbers()
        {
            double avr = Average.Average.AverageNumbers(new double[] { 7.8, 8.2,5.0 });
            double expected = 7.00;
            Assert.AreEqual(expected, avr);
        }
        [Test]
        public void Test_AverageEmptyArr()
        {
            double avr = Average.Average.AverageNumbers(new double[] { });
            double expected = 0;
            Assert.AreEqual(expected, avr);
        }

        [Test]
        public void Test_AverageWithZero()
        {
            double avr = Average.Average.AverageNumbers(new double[] {0 });
            double expected = 0;
            Assert.AreEqual(expected, avr);
        }

        [Test]
        public void Test_AverageWithNegativeNumbers()
        {
            double avr = Average.Average.AverageNumbers(new double[] { -10,-5 });
            double expected = -7.50;
            Assert.AreEqual(expected, avr);
        }

        [Test]
        public void Test_AverageWithNegativeAndPositiveNumbers()
        {
            double avr = Average.Average.AverageNumbers(new double[] { -10, 5 });
            double expected = -2.50;
            Assert.AreEqual(expected, avr);
        }

        [Test]
        public void Test_AverageBigNumbers()
        {
            double avr = Average.Average.AverageNumbers(new double[] { -1000000000, 5000000000 });
            double expected = 2000000000;
            Assert.AreEqual(expected, avr);
        }
    }
}