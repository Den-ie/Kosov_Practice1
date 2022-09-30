using System;

namespace Lib_4
{
    public static class MathString
    {
        /// <summary>
        /// Создание массива
        /// </summary>
        /// <param name="lenght">Длинна массива</param>
        /// <param name="from">Начальное значение диапозона</param>
        /// <param name="to">Конечное значение диапозона</param>
        /// <returns></returns>
        /// 
        public static int[] ArrayCreate(int lenght, int from = 10, int to = 40)
        {
            int[] numbers = new int[lenght];
            Random r = new Random();

            for (int i = 0; i < lenght; i++)
            {
                numbers[i] = r.Next(from, to);
            }
            return numbers;
        }
        
        /// <summary>
        /// Расчет минимального числа в массиве
        /// </summary>
        /// <param name="numbers">Числа в массива</param>
        /// <returns></returns>
        /// 
        public static int MyMin(this int[]numbers)
        {
            int Min = numbers[0];

            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] < Min)
                        Min = numbers[i];
            }

            return Min;
        }

    }
}
