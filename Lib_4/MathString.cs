using System;

namespace Lib_4
{
    public static class MathString
    {
        /// <summary>
        /// �������� �������
        /// </summary>
        /// <param name="lenght">������ �������</param>
        /// <param name="from">��������� �������� ���������</param>
        /// <param name="to">�������� �������� ���������</param>
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
        /// ������ ������������ ����� � �������
        /// </summary>
        /// <param name="numbers">����� � �������</param>
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
