using Ethica.Measurements.Lengths;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;

namespace Ethica.Tests
{
    /// <summary>
    ///This is a test class for LengthTest and is intended
    ///to contain all LengthTest Unit Tests
    ///</summary>
    [TestClass()]
    public class LengthTest
    {
        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext { get; set; }

        #region Additional test attributes
        // 
        //You can use the following additional attributes as you write your tests:
        //
        //Use ClassInitialize to run code before running the first test in the class
        //[ClassInitialize()]
        //public static void MyClassInitialize(TestContext testContext)
        //{
        //}
        //
        //Use ClassCleanup to run code after all tests in a class have run
        //[ClassCleanup()]
        //public static void MyClassCleanup()
        //{
        //}
        //
        //Use TestInitialize to run code before running each test
        //[TestInitialize()]
        //public void MyTestInitialize()
        //{
        //}
        //
        //Use TestCleanup to run code after each test has run
        //[TestCleanup()]
        //public void MyTestCleanup()
        //{
        //}
        //
        #endregion

  
        /// <summary>
        ///Test Length Constructor
        ///</summary>
        [TestMethod()]
        public void ConvertMeterToCentimeter()
        {
            var target = new Length(1);         // 1 meter
            Assert.AreEqual(1, target.Value);
            Assert.AreEqual(100, target.ConvertTo(LengthUnit.Centimeters).Value);
        }


        /// <summary>
        ///A test for Length Constructor
        ///</summary>
        [TestMethod()]
        public void ConvertInchesToFeet()
        {
            var target = new Length(12, LengthUnit.Inches);
            Assert.AreEqual(1, target.ConvertTo(LengthUnit.Feet).Value);
        }

        /// <summary>
        ///A test for CompareTo
        ///</summary>
        [TestMethod()]
        public void CompareToCentimeter()
        {
            var target = new Length(1);
            var other = new Centimeters(100);
            int actual = target.CompareTo(other);
            Assert.AreEqual(0, actual);
        }

        /// <summary>
        ///A test for CompareTo
        ///</summary>
        [TestMethod()]
        public void CompareToMilliMeter()
        {
            var target = new Length(1);
            var other = new Millimeters(1000);
            int actual = target.CompareTo(other);
            Assert.AreEqual(0, actual);
        }

        /// <summary>
        ///A test for CompareTo
        ///</summary>
        [TestMethod()]
        public void CompareToMeter()
        {
            var target = new Length(1);
            var other = new Meters(1);
            int actual = target.CompareTo(other);
            Assert.AreEqual(0, actual);
        }


        /// <summary>
        ///A test for CompareTo
        ///</summary>
        [TestMethod()]
        public void CompareToTest4()
        {
            var target = new Length(1);
            var other = new Length(2);
            int actual = target.CompareTo(other);
            Assert.AreEqual(-1, actual);
        }

        /// <summary>
        ///A test for CompareTo
        ///</summary>
        [TestMethod()]
        public void CompareToNanometer()
        {
            var target = new Length(0.000000001M);
            var other = new Nanometers(1);
            int actual = target.CompareTo(other);
            Assert.AreEqual(0, actual);
        }

        [TestMethod(), TestCategory("String Formatting"), Description("Test Conversion to string meter condensed")]
        public void ToStringTest()
        {
            var target = new Length(15M);
            var expected = "15m";
            var actual = target.ToString("g", null);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod(), TestCategory("String Formatting"), Description("Test Conversion to string inches condensed")]
        public void ToStringTest2()
        {
            var target = new Length(24, LengthUnit.Inches);
            var expected = "2' 0\"";
            var actual = target.ToString("fi", null);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod(), TestCategory("String Formatting"), Description("Test Conversion to string feet and inches condensed")]
        public void ToStringTest3()
        {
            var target = new Length(25, LengthUnit.Inches);
            var expected = "2' 1\"";
            var actual = target.ToString("fi", null);
            Assert.AreEqual(expected, actual);
        }

    


        /// <summary>
        ///A test for ToString
        ///</summary>
        [TestMethod(), TestCategory("String Formatting"), Description("Test Conversion to string inch (single form)")]
        public void ToStringTestInches()
        {
            var target = new Length(1, LengthUnit.Inches);
            var expected = "1 inch";
            var actual = target.ToString("G", null);
            Assert.AreEqual(expected, actual);
        }


        [TestMethod(), TestCategory("String Formatting"), Description("Test Conversion to string inches (plural form)")]
        public void ToStringTestInchesLong()
        {
            var target = new Length(3.5M, LengthUnit.Inches);
            var expected = "3.5 inches";
            var actual = target.ToString("G", null);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod(), TestCategory("String Formatting"), Description("Test Conversion to string Feet and Inches (plural form)")]
        public void TestToStringFeetAndInchesPlural()
        {
            var target = new Length(3.25M, LengthUnit.Feet);
            var expected = "3 feet 3 inches";
            var actual = target.ToString("FI", null);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod(), TestCategory("String Formatting"), Description("Test Conversion to string Feet and Inches (single form)")]
        public void TestToStringFeetAndInchesSingular()
        {
            var target = new Length(1.25M, LengthUnit.Feet);
            var expected = "1 foot 3 inches";
            var actual = target.ToString("FI", null);
            Assert.AreEqual(expected, actual);

            var t2 = (Feet)target;
            actual = t2.ToString("FI");
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///A test for TryParse
        ///</summary>
        [TestMethod()]
        public void TryParseTest()
        {
            Length value;
            Assert.IsTrue(Length.TryParse("15 meters", out value));
            Length valueExpected = new Length(15);
            Assert.AreEqual(valueExpected, value);
        }


        [TestMethod()]
        public void TryParseAll1()
        {
            var rand = new Random();
            foreach (LengthUnit unit in Enum.GetValues(typeof(LengthUnit)).Cast<LengthUnit>())
            {
                Length value = new Length(rand.Next(1000), unit);
                var asString = value.ToString("g", null);
                Length value2;
                Assert.IsTrue(Length.TryParse(asString, out value2));
                Assert.AreEqual(value2, value);
            }
        }



    }
}
