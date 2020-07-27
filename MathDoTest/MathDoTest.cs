using Microsoft.VisualStudio.TestTools.UnitTesting;
using Xunit.Sdk;
using MathDo;

namespace MathDoTest
{
    [TestClass]
    public class MathDoTest
    {
        public readonly double _valueForGeneralTest;
        public MathDoTest()
        {
            _valueForGeneralTest = 105.14528752963;
        }


        [TestMethod]
        public void TrucanteValueWithTwoDecimalPlace()
        {
            var truncateValue = MathDoCalc.Truncate(_valueForGeneralTest, 2);
            Assert.AreEqual(105.14, truncateValue);
        }

        [TestMethod]
        public void TrucanteValueWithThreeDecimalPlace()
        {
            var truncateValue = MathDoCalc.Truncate(_valueForGeneralTest, 3);
            Assert.AreEqual(105.145, truncateValue);
        }

        [TestMethod]
        public void TrucanteValueWithFourDecimalPlace()
        {
            var truncateValue = MathDoCalc.Truncate(_valueForGeneralTest, 4);
            Assert.AreEqual(105.1452, truncateValue);
        }

        [TestMethod]
        public void TrucanteValueWithFiveDecimalPlace()
        {
            var truncateValue = MathDoCalc.Truncate(_valueForGeneralTest, 5);
            Assert.AreEqual(105.14528, truncateValue);
        }
    }
}
