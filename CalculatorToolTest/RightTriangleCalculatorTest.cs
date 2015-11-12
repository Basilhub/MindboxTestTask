using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using GeometricShapesCalculator;

namespace GeometricShapesCalculatorTest
{
    /// <summary>
    /// Класс содержащий в себе методы тестирования
    /// </summary>
    [TestClass]
    public class RightTriangleCalculatorTest
    {
        /// <summary>
        /// Тест на генерацию исключения в том случае, если один из параметров - отрицательное число. 
        /// </summary>
        [TestMethod]
        public void NegativeNumberParamsTest()
        {
            try
            {
                double a = 5;
                double b = -7;
                RightTriangleCalculator.GetArea(a, b);
                Assert.Fail("No exception");
            }
            catch (Exception ex)
            {
                Assert.IsTrue(ex is ArgumentException);
            }
        }

        /// <summary>
        /// Тест для проверки нормальных значений параметров (положительные числа)
        /// </summary>
        [TestMethod]
        public void RightNumberParamsTest()
        {
            double a = 5;
            double b = 6;
            double expected = 15;
            double actual = RightTriangleCalculator.GetArea(a, b);
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// Тест для проверки положительных граничных значений параметров (double.MaxValue)
        /// </summary>
        [TestMethod]
        public void DoubleTypeBorderParamsTest()
        {
            double actual = RightTriangleCalculator.GetArea(double.MaxValue, double.MaxValue);
            Assert.IsTrue(double.IsPositiveInfinity(actual));
        }
    }
}
