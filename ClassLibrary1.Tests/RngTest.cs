using ClassLibrary1;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ClassLibrary1.Tests
{
    [TestClass]
    public class RngTest
    {
        [TestMethod]
        public void IsGeneratedValueSevenDigits()
        {
            string value = Rng.GenerateValue();

            Assert.AreEqual(7, value.Length);
        }

        [TestMethod]
        public void DoesGeneratedValueContainCorrectNumbers()
        {
            string value = Rng.GenerateValue();

            Assert.IsTrue(value.Contains('8'));
            Assert.IsTrue(value.Contains('6'));
            Assert.IsTrue(value.Contains('9'));
            Assert.IsTrue(value.Contains('0'));
            Assert.IsTrue(value.Contains('3'));
        }
    }
}
