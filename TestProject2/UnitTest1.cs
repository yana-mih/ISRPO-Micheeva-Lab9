using System;
using ClassLibrary1;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            SquareMatrix matrix = new SquareMatrix(3);
            matrix[0] = 1.13;
            matrix[1] = 4.23;
            matrix[2] = 9.67;
            matrix[3] = 6.89;
            matrix[4] = 11.01;
            matrix[5] = 89.34;
            matrix[6] = 34.235;
            matrix[7] = 67.46;
            matrix[8] = 12.17;
            double expected = 237.135;

            double actual = matrix.CalculateDiagonalProduct();
            Assert.AreEqual(expected, actual, 0.001);


        }
        [TestMethod]
        public void TestMethod2()
        {
            SquareMatrix matrix = new SquareMatrix(3);
            matrix[0] = 1.13;
            matrix[1] = 4.23;
            matrix[2] = 9.67;
            matrix[3] = 6.89;
            matrix[4] = 11.01;
            matrix[5] = 89.34;
            matrix[6] = 34.235;
            matrix[7] = 67.46;
            matrix[8] = 12.17;
            double expected1 = 4.23;

            double actual1 = matrix[1];
            Assert.AreEqual(expected1, actual1);


        }
    }
}