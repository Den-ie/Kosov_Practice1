using System;

namespace Lib_4
{
    public static class Calculating
    {
        public static int[] ArrayCreate(in int lenght) 
        {
            int[] numbers = new int[lenght];
            Random r = new Random();

            for (int i = 0; i < lenght; i++) 
            {
                numbers[i] = r.Next(10,41);
            }
            return numbers;
        }
    }
}
