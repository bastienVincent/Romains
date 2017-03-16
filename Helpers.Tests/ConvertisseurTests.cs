using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Helpers.Interfaces;
using Helpers.Implementations;

namespace Helpers.Tests
{
    /// <summary>
    /// Summary description for ConvertisseurTests
    /// </summary>
    [TestClass]
    public class ConvertisseurTests
    {
        public ConvertisseurTests()
        {
        }

        private TestContext testContextInstance;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region Additional test attributes
        //
        // You can use the following additional attributes as you write your tests:
        //
        // Use ClassInitialize to run code before running the first test in the class
        // [ClassInitialize()]
        // public static void MyClassInitialize(TestContext testContext) { }
        //
        // Use ClassCleanup to run code after all tests in a class have run
        // [ClassCleanup()]
        // public static void MyClassCleanup() { }
        //
        // Use TestInitialize to run code before running each test 
        // [TestInitialize()]
        // public void MyTestInitialize() { }
        //
        // Use TestCleanup to run code after each test has run
        // [TestCleanup()]
        // public void MyTestCleanup() { }
        //
        #endregion

        [TestMethod]
        public void GivenLess0WhenConvertThenEmpty()
        {
            string res = new ConvertisseurRomain().ConvertirEnNombreRomain(-1);
            Assert.IsTrue(String.IsNullOrEmpty(res));
        }

        [TestMethod]
        public void GivenMore4999WhenConvertThenEmpty()
        {
            string res = new ConvertisseurRomain().ConvertirEnNombreRomain(5000);
            Assert.IsTrue(String.IsNullOrEmpty(res));
        }

        [TestMethod]
        public void Given1234WhenConvertThenValue()
        {
            string res = new ConvertisseurRomain().ConvertirEnNombreRomain(1234);
            Assert.AreEqual(res, "MCCXXXIV");
        }

        [TestMethod]
        public void GivenIntWhenConvertThenValue()
        {
            var convert = new ConvertisseurRomain();
            PrivateObject privConvert = new PrivateObject(convert);

            Object[] arg = {0};

            string res = (string)privConvert.Invoke("RetournerEntierRomain", arg);
            Assert.AreEqual(res, "");

            arg[0] = 1;
            res = (string)privConvert.Invoke("RetournerEntierRomain", arg);
            Assert.AreEqual(res, "I");

            arg[0] = 2;
            res = (string)privConvert.Invoke("RetournerEntierRomain", arg);
            Assert.AreEqual(res, "II");

            arg[0] = 3;
            res = (string)privConvert.Invoke("RetournerEntierRomain", arg);
            Assert.AreEqual(res, "III");

            arg[0] = 4;
            res = (string)privConvert.Invoke("RetournerEntierRomain", arg);
            Assert.AreEqual(res, "IV");

            arg[0] = 5;
            res = (string)privConvert.Invoke("RetournerEntierRomain", arg);
            Assert.AreEqual(res, "V");

            arg[0] = 6;
            res = (string)privConvert.Invoke("RetournerEntierRomain", arg);
            Assert.AreEqual(res, "VI");

            arg[0] = 7;
            res = (string)privConvert.Invoke("RetournerEntierRomain", arg);
            Assert.AreEqual(res, "VII");

            arg[0] = 8;
            res = (string)privConvert.Invoke("RetournerEntierRomain", arg);
            Assert.AreEqual(res, "VIII");

            arg[0] = 9;
            res = (string)privConvert.Invoke("RetournerEntierRomain", arg);
            Assert.AreEqual(res, "IX");

        }

        [TestMethod]
        public void GivenTensWhenConvertThenValue()
        {
            var convert = new ConvertisseurRomain();
            PrivateObject privConvert = new PrivateObject(convert);

            Object[] arg = { 0 };

            string res = (string)privConvert.Invoke("RetournerDizaineRomain", arg);
            Assert.AreEqual(res, "");

            arg[0] = 1;
            res = (string)privConvert.Invoke("RetournerDizaineRomain", arg);
            Assert.AreEqual(res, "X");

            arg[0] = 2;
            res = (string)privConvert.Invoke("RetournerDizaineRomain", arg);
            Assert.AreEqual(res, "XX");

            arg[0] = 3;
            res = (string)privConvert.Invoke("RetournerDizaineRomain", arg);
            Assert.AreEqual(res, "XXX");

            arg[0] = 4;
            res = (string)privConvert.Invoke("RetournerDizaineRomain", arg);
            Assert.AreEqual(res, "XL");

            arg[0] = 5;
            res = (string)privConvert.Invoke("RetournerDizaineRomain", arg);
            Assert.AreEqual(res, "L");

            arg[0] = 6;
            res = (string)privConvert.Invoke("RetournerDizaineRomain", arg);
            Assert.AreEqual(res, "LX");

            arg[0] = 7;
            res = (string)privConvert.Invoke("RetournerDizaineRomain", arg);
            Assert.AreEqual(res, "LXX");

            arg[0] = 8;
            res = (string)privConvert.Invoke("RetournerDizaineRomain", arg);
            Assert.AreEqual(res, "LXXX");

            arg[0] = 9;
            res = (string)privConvert.Invoke("RetournerDizaineRomain", arg);
            Assert.AreEqual(res, "XC");

        }

        [TestMethod]
        public void GivenHundredsWhenConvertThenValue()
        {
            var convert = new ConvertisseurRomain();
            PrivateObject privConvert = new PrivateObject(convert);

            Object[] arg = { 0 };

            string res = (string)privConvert.Invoke("RetournerCentaineRomain", arg);
            Assert.AreEqual(res, "");

            arg[0] = 1;
            res = (string)privConvert.Invoke("RetournerCentaineRomain", arg);
            Assert.AreEqual(res, "C");

            arg[0] = 2;
            res = (string)privConvert.Invoke("RetournerCentaineRomain", arg);
            Assert.AreEqual(res, "CC");

            arg[0] = 3;
            res = (string)privConvert.Invoke("RetournerCentaineRomain", arg);
            Assert.AreEqual(res, "CCC");

            arg[0] = 4;
            res = (string)privConvert.Invoke("RetournerCentaineRomain", arg);
            Assert.AreEqual(res, "CD");

            arg[0] = 5;
            res = (string)privConvert.Invoke("RetournerCentaineRomain", arg);
            Assert.AreEqual(res, "D");

            arg[0] = 6;
            res = (string)privConvert.Invoke("RetournerCentaineRomain", arg);
            Assert.AreEqual(res, "DC");

            arg[0] = 7;
            res = (string)privConvert.Invoke("RetournerCentaineRomain", arg);
            Assert.AreEqual(res, "DCC");

            arg[0] = 8;
            res = (string)privConvert.Invoke("RetournerCentaineRomain", arg);
            Assert.AreEqual(res, "DCCC");

            arg[0] = 9;
            res = (string)privConvert.Invoke("RetournerCentaineRomain", arg);
            Assert.AreEqual(res, "CM");

        }

        [TestMethod]
        public void GivenThousandWhenConvertThenValue()
        {
            var convert = new ConvertisseurRomain();
            PrivateObject privConvert = new PrivateObject(convert);

            Object[] arg = { 0 };

            string res = (string)privConvert.Invoke("RetournerMillierRomain", arg);
            Assert.AreEqual(res, "");

            arg[0] = 1;
            res = (string)privConvert.Invoke("RetournerMillierRomain", arg);
            Assert.AreEqual(res, "M");

            arg[0] = 2;
            res = (string)privConvert.Invoke("RetournerMillierRomain", arg);
            Assert.AreEqual(res, "MM");

            arg[0] = 3;
            res = (string)privConvert.Invoke("RetournerMillierRomain", arg);
            Assert.AreEqual(res, "MMM");

            arg[0] = 4;
            res = (string)privConvert.Invoke("RetournerMillierRomain", arg);
            Assert.AreEqual(res, "MMMM");



        }

    }
}

