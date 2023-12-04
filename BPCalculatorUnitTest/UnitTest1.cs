using Microsoft.VisualStudio.TestTools.UnitTesting;
using BPCalculator;

namespace BPCalculatorUnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethodLow()
        {
            BloodPressure bp = new BloodPressure() { Systolic = 80, Diastolic = 50 };
            Assert.AreEqual(bp.Category, BPCategory.Low);
        }

        [TestMethod]
        public void TestMethodIdeal()
        {
            BloodPressure bp = new BloodPressure() { Systolic = 110, Diastolic = 70 };
            Assert.AreEqual(bp.Category, BPCategory.Ideal);
        }

        [TestMethod]
        public void TestMethodPreHigh()
        {
            BloodPressure bp = new BloodPressure() { Systolic = 130, Diastolic = 85 };
            Assert.AreEqual(bp.Category, BPCategory.PreHigh);
        }

        [TestMethod]
        public void TestMethodHigh()
        {
            BloodPressure bp = new BloodPressure() { Systolic = 170, Diastolic = 95 };
            Assert.AreEqual(bp.Category, BPCategory.High);
        }
        
    }
}