using System;
using ConsoleAppProject.App02;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ConsoleApp.Tests
{
    [TestClass]
    public class TestBMICalculator
    {
        [TestMethod]
        public void TestLowestUnderweightMetric()
        {
            BMICalculator bmi = new BMICalculator();

            bmi.Kilograms = 45.5;
            bmi.Centimetres = 193;

            bmi.CalculateMetric();

            double expectedBMI = 12;

            /// Rounding BMI to the nearest integer as the tests
            /// based on the BMI chart are all in integers
            Assert.AreEqual(expectedBMI, Math.Round(bmi.User_BMI));
        }

        [TestMethod]
        public void TestLowestUnderweightImperial()
        {
            BMICalculator bmi = new BMICalculator();

            bmi.Pounds = 100;
            bmi.Feet = 6;
            bmi.Inches = 4;

            bmi.CalculateImperial();

            double expectedBMI = 12;

            /// Rounding BMI to the nearest integer as the tests
            /// based on the BMI chart are all in integers
            Assert.AreEqual(expectedBMI, Math.Round(bmi.User_BMI));
        }
    }
}
