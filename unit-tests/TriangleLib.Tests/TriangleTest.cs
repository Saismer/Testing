using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TriangleLib.Tests
{
    [TestClass]
    public class TriangleTest
    {
        //1
        [TestMethod]
        public void CheckTriangle_trueTriangle_returnedtrue()
        {
            double a = 3;
            double b = 4;
            double c = 5;
            bool expected = true;

            Triangle tr = new Triangle();
            bool actual = tr.CheckTriangle(a, b, c);
            Assert.AreEqual(expected, actual);
        }

        //2
        [TestMethod]
        public void CheckTriangle_belowZero_returnedfalse()
        {
            double a = -3;
            double b = -1;
            double c = 5;
            bool expected = false;

            Triangle tr = new Triangle();
            bool actual = tr.CheckTriangle(a, b, c);
            Assert.AreEqual(expected, actual);
        }

        //3
        [TestMethod]
        public void CheckTriangle_zeroValue_returnedfalse()
        {
            double a = 0;
            double b = 3;
            double c = 5;
            bool expected = false;

            Triangle tr = new Triangle();
            bool actual = tr.CheckTriangle(a, b, c);
            Assert.AreEqual(expected, actual);
        }

        //4
        [TestMethod]
        public void CheckTriangle_sumOfAandBEqualsC_returnedfalse()
        {
            double a = 2;
            double b = 3;
            double c = 5;
            bool expected = false;

            Triangle tr = new Triangle();
            bool actual = tr.CheckTriangle(a, b, c);
            Assert.AreEqual(expected, actual);
        }

        //5
        [TestMethod]
        public void CheckTriangle_testDoublePrecision_returnedtrue()
        {
            double a = 2;
            double b = 3;
            double c = 4.99999999999999;
            bool expected = true;

            Triangle tr = new Triangle();
            bool actual = tr.CheckTriangle(a, b, c);
            Assert.AreEqual(expected, actual);
        }

        //6
        [TestMethod]
        public void CheckTriangle_sumOfAandBLessC_returnedfalse()
        {
            double a = 2;
            double b = 3;
            double c = 8;
            bool expected = false;

            Triangle tr = new Triangle();
            bool actual = tr.CheckTriangle(a, b, c);
            Assert.AreEqual(expected, actual);
        }

        //7
        [TestMethod]
        public void CheckTriangle_sideNearZero_returnedtrue()
        {
            double a = 0.00000000000001 ;
            double b = 3;
            double c = 3;
            bool expected = true;

            Triangle tr = new Triangle();
            bool actual = tr.CheckTriangle(a, b, c);
            Assert.AreEqual(expected, actual);
        }

        //8
        [TestMethod]
        public void CheckTriangle_oneZeroAndOneBelowZero_returnedfalse()
        {
            double a = 0;
            double b = -2;
            double c = 3;
            bool expected = false;

            Triangle tr = new Triangle();
            bool actual = tr.CheckTriangle(a, b, c);
            Assert.AreEqual(expected, actual);
        }

        //9
        [TestMethod]
        public void CheckTriangle_allSidesEquals_returnedtrue()
        {
            double a = 3;
            double b = 3;
            double c = 3;
            bool expected = true;

            Triangle tr = new Triangle();
            bool actual = tr.CheckTriangle(a, b, c);
            Assert.AreEqual(expected, actual);
        }

        //9
        [TestMethod]
        public void CheckTriangle_DoubleAndIntAndFloatSides_returnedtrue()
        {
            int a = 3;
            double b = 3.024;
            float c = 3.6743f;
            bool expected = true;

            Triangle tr = new Triangle();
            bool actual = tr.CheckTriangle(a, b, c);
            Assert.AreEqual(expected, actual);
        }
    }
}
