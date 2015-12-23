using System;
using System.Numerics;


namespace Factorialform.Logic
{
    /// <summary>
    /// Класс, в котором реализовано все, относящееся к математике
    /// </summary>
    static class Logic
    {
        static private Int32 MaxValue = 5000;
        static private Int32 MinValue = 0;

 
        private static BigInteger FactTree( int left, int right )
        {
            if (left > right)
                return (BigInteger)1;

            if (left == right)
                return (BigInteger)left;

            if (right - left == 1)
                return (BigInteger)(left * right);

            int s = (int)((left + right) / 2);

            return FactTree(left, s) * FactTree(s + 1, right);
        }

        /// <summary>
        /// Вычисление акториала методом бинарного дерева
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static BigInteger Factorial( Int32 input )
        {
            if (input < 0)
                throw new LogicException("Your input number must be >= 0!");

            if (input == 0 || input == 1)
                return 1;

            if (input == 2)
                return 2;

            return FactTree( 2, input );
        }

        /// <summary>
        /// Генерация произвольного числа
        /// </summary>
        /// <returns></returns>
        public static Int32 Random()
        {
            Random randg = new Random(DateTime.Now.Millisecond);
            return randg.Next(MinValue, MaxValue);
        }
    }
}
