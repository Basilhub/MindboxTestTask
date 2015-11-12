using System;

namespace GeometricShapesCalculator
{
    /// <summary>
    /// Класс-библиотека для методов вычисления характеристик правильного треугольника
    /// </summary>
    public static class RightTriangleCalculator
    {
        /// <summary>
        /// Метод вычисляющий площадь прямоугольного треугольника
        /// </summary>
        /// <param name="a"> Катет А </param>
        /// <param name="b"> Катет Б </param>
        /// <returns> Вычисленная площадь </returns>
        public static double GetArea(double a, double b)
        {
            try
            {
                // Контракт проверки данных
                if (a <= 0 || b <= 0)
                    throw new ArgumentException("Стороны треугольника должны быть больше нуля");
                // Вычисление площади
                var area = 0.5 * (a * b);
                // Возвращение результата
                return area;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
