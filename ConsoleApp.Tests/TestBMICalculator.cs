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

            /// Rounding BMI down to the nearest integer as the tests
            /// based on the BMI chart are all in integers
            Assert.AreEqual(expectedBMI, Math.Floor(bmi.User_BMI));
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

            /// Rounding BMI down to the nearest integer as the tests
            /// based on the BMI chart are all in integers
            Assert.AreEqual(expectedBMI, Math.Floor(bmi.User_BMI));
        }

        [TestMethod]
        public void TestHighestUnderweightMetric()
        {
            BMICalculator bmi = new BMICalculator();

            bmi.Kilograms = 68.2;
            bmi.Centimetres = 193;

            bmi.CalculateMetric();

            double expectedBMI = 18;

            Assert.AreEqual(expectedBMI, Math.Floor(bmi.User_BMI));
        }

        [TestMethod]
        public void TestHighestUnderweightImperial()
        {
            BMICalculator bmi = new BMICalculator();

            bmi.Pounds = 150;
            bmi.Feet = 6;
            bmi.Inches = 4;

            bmi.CalculateImperial();

            double expectedBMI = 18;

            Assert.AreEqual(expectedBMI, Math.Floor(bmi.User_BMI));
        }

        [TestMethod]
        public void TestLowestNormalMetric()
        {
            BMICalculator bmi = new BMICalculator();

            bmi.Kilograms = 47.1;
            bmi.Centimetres = 160;

            bmi.CalculateMetric();

            double expectedBMI = 18;

            Assert.AreEqual(expectedBMI, Math.Floor(bmi.User_BMI));
        }

        [TestMethod]
        public void TestLowestNormalImperial()
        {
            BMICalculator bmi = new BMICalculator();

            bmi.Pounds = 105;
            bmi.Feet = 5;
            bmi.Inches = 3;

            bmi.CalculateImperial();

            double expectedBMI = 18;

            Assert.AreEqual(expectedBMI, Math.Floor(bmi.User_BMI));
        }

        [TestMethod]
        public void TestHighestNormalMetric()
        {
            BMICalculator bmi = new BMICalculator();

            bmi.Kilograms = 63.6;
            bmi.Centimetres = 160;

            bmi.CalculateMetric();

            double expectedBMI = 24;

            Assert.AreEqual(expectedBMI, Math.Floor(bmi.User_BMI));
        }

        [TestMethod]
        public void TestHighestNormalImperial()
        {
            BMICalculator bmi = new BMICalculator();

            bmi.Pounds = 140;
            bmi.Feet = 5;
            bmi.Inches = 3;

            bmi.CalculateImperial();

            double expectedBMI = 24;

            Assert.AreEqual(expectedBMI, Math.Floor(bmi.User_BMI));
        }

        [TestMethod]
        public void TestLowestOverweightMetric()
        {
            BMICalculator bmi = new BMICalculator();

            bmi.Kilograms = 65.9;
            bmi.Centimetres = 160;

            bmi.CalculateMetric();

            double expectedBMI = 25;

            Assert.AreEqual(expectedBMI, Math.Floor(bmi.User_BMI));
        }

        [TestMethod]
        public void TestLowestOverweightImperial()
        {
            BMICalculator bmi = new BMICalculator();

            bmi.Pounds = 145;
            bmi.Feet = 5;
            bmi.Inches = 3;

            bmi.CalculateImperial();

            double expectedBMI = 25;

            Assert.AreEqual(expectedBMI, Math.Floor(bmi.User_BMI));
        }

        [TestMethod]
        public void TestHighestOverweightMetric()
        {
            BMICalculator bmi = new BMICalculator();

            bmi.Kilograms = 75;
            bmi.Centimetres = 160;

            bmi.CalculateMetric();

            double expectedBMI = 29;

            Assert.AreEqual(expectedBMI, Math.Floor(bmi.User_BMI));
        }

        [TestMethod]
        public void TestHighestOverweightImperial()
        {
            BMICalculator bmi = new BMICalculator();

            bmi.Pounds = 165;
            bmi.Feet = 5;
            bmi.Inches = 3;

            bmi.CalculateImperial();

            double expectedBMI = 29;

            Assert.AreEqual(expectedBMI, Math.Floor(bmi.User_BMI));
        }

        [TestMethod]
        public void TestLowestObeseFirstMetric()
        {
            BMICalculator bmi = new BMICalculator();

            bmi.Kilograms = 77.3;
            bmi.Centimetres = 160;

            bmi.CalculateMetric();

            double expectedBMI = 30;

            Assert.AreEqual(expectedBMI, Math.Floor(bmi.User_BMI));
        }

        [TestMethod]
        public void TestLowestObeseFirstImperial()
        {
            BMICalculator bmi = new BMICalculator();

            bmi.Pounds = 170;
            bmi.Feet = 5;
            bmi.Inches = 3;

            bmi.CalculateImperial();

            double expectedBMI = 30;

            Assert.AreEqual(expectedBMI, Math.Floor(bmi.User_BMI));
        }

        [TestMethod]
        public void TestHighestObeseFirstMetric()
        {
            BMICalculator bmi = new BMICalculator();

            bmi.Kilograms = 88.6;
            bmi.Centimetres = 160;

            bmi.CalculateMetric();

            double expectedBMI = 34;

            Assert.AreEqual(expectedBMI, Math.Floor(bmi.User_BMI));
        }

        [TestMethod]
        public void TestHighestObeseFirstImperial()
        {
            BMICalculator bmi = new BMICalculator();

            bmi.Pounds = 195;
            bmi.Feet = 5;
            bmi.Inches = 3;

            bmi.CalculateImperial();

            double expectedBMI = 34;

            Assert.AreEqual(expectedBMI, Math.Floor(bmi.User_BMI));
        }

        [TestMethod]
        public void TestLowestObeseSecondMetric()
        {
            BMICalculator bmi = new BMICalculator();

            bmi.Kilograms = 90.9;
            bmi.Centimetres = 160;

            bmi.CalculateMetric();

            double expectedBMI = 35;

            Assert.AreEqual(expectedBMI, Math.Floor(bmi.User_BMI));
        }

        [TestMethod]
        public void TestLowestObeseSecondImperial()
        {
            BMICalculator bmi = new BMICalculator();

            bmi.Pounds = 200;
            bmi.Feet = 5;
            bmi.Inches = 3;

            bmi.CalculateImperial();

            double expectedBMI = 35;

            Assert.AreEqual(expectedBMI, Math.Floor(bmi.User_BMI));
        }

        [TestMethod]
        public void TestHighestObeseSecondMetric()
        {
            BMICalculator bmi = new BMICalculator();

            bmi.Kilograms = 90.9;
            bmi.Centimetres = 152.4;

            bmi.CalculateMetric();

            double expectedBMI = 39;

            Assert.AreEqual(expectedBMI, Math.Floor(bmi.User_BMI));
        }

        [TestMethod]
        public void TestHighestObeseSecondImperial()
        {
            BMICalculator bmi = new BMICalculator();

            bmi.Pounds = 200;
            bmi.Feet = 5;
            bmi.Inches = 0;

            bmi.CalculateImperial();

            double expectedBMI = 39;

            Assert.AreEqual(expectedBMI, Math.Floor(bmi.User_BMI));
        }

        [TestMethod]
        public void TestLowestObeseThirdMetric()
        {
            BMICalculator bmi = new BMICalculator();

            bmi.Kilograms = 93.2;
            bmi.Centimetres = 152.4;

            bmi.CalculateMetric();

            double expectedBMI = 40;

            Assert.AreEqual(expectedBMI, Math.Floor(bmi.User_BMI));
        }

        [TestMethod]
        public void TestLowestObeseThirdImperial()
        {
            BMICalculator bmi = new BMICalculator();

            bmi.Pounds = 205;
            bmi.Feet = 5;
            bmi.Inches = 0;

            bmi.CalculateImperial();

            double expectedBMI = 40;

            Assert.AreEqual(expectedBMI, Math.Floor(bmi.User_BMI));
        }

        [TestMethod]
        public void TestHighestObeseThirdMetric()
        {
            BMICalculator bmi = new BMICalculator();

            bmi.Kilograms = 97.7;
            bmi.Centimetres = 152.4;

            bmi.CalculateMetric();

            double expectedBMI = 42;

            Assert.AreEqual(expectedBMI, Math.Floor(bmi.User_BMI));
        }

        [TestMethod]
        public void TestHighestObeseThirdImperial()
        {
            BMICalculator bmi = new BMICalculator();

            bmi.Pounds = 215;
            bmi.Feet = 5;
            bmi.Inches = 0;

            bmi.CalculateImperial();

            double expectedBMI = 42;

            /// Actual value is 41.9 and the BMI chart has this
            /// rounded up to 42, so this will be rounded up
            /// instead of down.
            Assert.AreEqual(expectedBMI, Math.Round(bmi.User_BMI));
        }
    }
}
