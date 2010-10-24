using System;
using System.Linq;
using Ethica.Measurements.Volumes;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Ethica.Tests
{
    /// <summary>
    ///This is a test class for VolumeTest and is intended
    ///to contain all VolumeTest Unit Tests
    ///</summary>
    [TestClass]
    public class VolumeTest
    {
        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext { get; set; }


        [TestMethod]
        public void ConvertCubicMeterToLiter()
        {
            var target = new Volume(1);
            decimal expected = 0.001M;
            var actual = target.ConvertTo(VolumeUnit.CubicMeters).Value;
            Assert.AreEqual(expected, actual );
        }


        [TestMethod]
        public void CompareToLiter()
        {
            var target = new Volume(1);
            var other = new Liters(1);
            int actual = target.CompareTo(other);
            Assert.AreEqual(0, actual);
        }


        [TestMethod]
        public void CompareToCubicMeter()
        {
            var target = new Volume(1);
            var other  = new CubicMeters(0.001M);
            int actual = target.CompareTo(other);
            Assert.AreEqual(0, actual);
        }


        [TestMethod]
        public void CompareToTest4()
        {
            var target = new Volume(1);
            var other = new Volume(2);
            int actual = target.CompareTo(other);
            Assert.AreEqual(-1, actual);
        }

        [TestMethod]
        public void CompareToCubicCentimeters()
        {
            var target = new Volume(0.000001M, VolumeUnit.CubicMeters);
            var other = new CubicCentimeters(1);
            int actual = target.CompareTo(other);
            Assert.AreEqual(0, actual);
        }


        [TestMethod, TestCategory("Conversion"), Description("Test round-trip via two measurements")]
        public void ConversionTest1()
        {
            var target = new Volume(1M);
            CubicCentimeters dm = target;
            CubicYards cyd = dm;
            int compare = target.CompareTo(cyd);
            Assert.AreEqual(0, compare);
        }


        [TestMethod, TestCategory("String Formatting"), Description("Test Conversion to string meter condensed")]
        public void ToStringTest()
        {
            var target = new Volume(15M);
            const string expected = "15L";
            string actual = target.ToString("g", null);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod, TestCategory("String Formatting"), Description("Test Conversion to string cubic inches condensed")]
        public void ToStringTest2()
        {
            var target = new Volume(24, VolumeUnit.CubicInches);
            const string expected = "24in³";
            string actual = target.ToString("g", null);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod, TestCategory("String Formatting"), Description("Test Conversion to string cubic inches expanded")]
        public void ToStringTest3()
        {
            var target = new Volume(25, VolumeUnit.CubicInches);
            const string expected = "25 cubic inches";
            string actual = target.ToString("G", null);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod, TestCategory("String Formatting"),
         Description("Test Conversion to string cubic inches expanded  (single form)")]
        public void ToStringTestInches()
        {
            var target = new Volume(1, VolumeUnit.CubicInches);
            const string expected = "1 cubic inch";
            string actual = target.ToString("G", null);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod, TestCategory("String Parsing"), Description("Parse cubic meters expanded")]
        public void TryParseTest1()
        {
            Volume value;
            Assert.IsTrue(Volume.TryParse("15 cubic meters", out value));
            var valueExpected = new Volume(15, VolumeUnit.CubicMeters);
            Assert.AreEqual(valueExpected, value);
        }


        [TestMethod, TestCategory("String Parsing"), Description("Parse cubic meters condensed")]
        public void TryParseTest2()
        {
            Volume value;
            Assert.IsTrue(Volume.TryParse("15 m³", out value));
            var valueExpected = new Volume(15, VolumeUnit.CubicMeters);
            Assert.AreEqual(valueExpected, value);
        }

        [TestMethod, TestCategory("String Parsing"),
         Description("Convert all units of measure to condensed string and parse back")]
        public void TryParseAllCondensed()
        {
            var rand = new Random();
            foreach (VolumeUnit unit in Enum.GetValues(typeof (VolumeUnit)).Cast<VolumeUnit>())
            {
                var value = new Volume(rand.Next(1000), unit);
                string asString = value.ToString("g", null);
                Volume value2;
                bool success = Volume.TryParse(asString, out value2);
                Assert.IsTrue(success);
                Assert.AreEqual(value2, value);
            }
        }

        [TestMethod, TestCategory("String Parsing"),
         Description("Convert all units of measure to expanded string and parse back")]
        public void TryParseAllExpanded()
        {
            var rand = new Random();
            foreach (VolumeUnit unit in Enum.GetValues(typeof (VolumeUnit)).Cast<VolumeUnit>())
            {
                var value = new Volume(rand.Next(1000), unit);
                string asString = value.ToString("G", null);
                Volume value2;
                Assert.IsTrue(Volume.TryParse(asString, out value2));
                Assert.AreEqual(value2, value);
            }
        }
    }
}