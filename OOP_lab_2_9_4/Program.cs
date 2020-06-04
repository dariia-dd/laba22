using System;

namespace OOP_lab_2_9_4
{
    public class Program
    {
        public static int IndexOfMaxAbs(int[] array)
        {
            int index = 0;

            for (int i = 0; i < array.Length; ++i)
            {
                if (Math.Abs(array[i]) >= Math.Abs(array[index]))
                {
                    index = i;
                }
            }

            return index;
        }

        private static int IndexOfPositive(int[] array)
        {
            for (int i = 0; i < array.Length; ++i)
            {
                if (array[i] > 0)
                {
                    return i;
                }
            }

            return -1;
        }

        public static int Multiplication(int[] array)
        {
            int index = IndexOfPositive(array);

            if ((index == -1) || (index == array.Length - 1))
            {
                return 0;
            }
            else
            {
                int d = 1;

                for (int i = index + 1; i < array.Length; ++i)
                {
                    d *= array[i];
                }

                return d;
            }
        }

        private static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            int[] array = new int[n];

            for (int i = 0; i < n; ++i)
            {
                array[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < n; ++i)
            {
                Console.WriteLine("a[{0}] = {1}", i, array[i]);
            }

            Console.WriteLine("Номер максимального за модулем елемента масиву: {0}", IndexOfMaxAbs(array));
            Console.WriteLine("Добуток елементiв масиву, розташованих пiсля першого додатного елемента: {0}", Multiplication(array));
        }
    }
}
