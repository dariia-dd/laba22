using System;

namespace OOP_lab_2_9_5
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Введiть розмiри матрицi");

            string str = Console.ReadLine();

            string[] size = str.Split(" ", StringSplitOptions.RemoveEmptyEntries);

            int m = int.Parse(size[0]);
            int n = int.Parse(size[1]);

            int[][] array = new int[n][];

            var random = new Random();

            for (int i = 0; i < n; ++i)
            {
                array[i] = new int[m];

                for (int j = 0; j < m; ++j)
                {
                    array[i][j] = random.Next(-100, 100);
                }
            }

            for (int i = 0; i < n; ++i)
            {
                for (int j = 0; j < m; ++j)
                {
                    Console.Write("{0, -5}", array[i][j]);
                }

                Console.WriteLine();
            }

            bool[] zero = new bool[n];

            for (int i = 0; i < n; ++i)
            {
                for (int j = 0; j < m; ++j)
                {
                    if (array[i][j] == 0)
                    {
                        zero[i] = true;
                        break;
                    }
                }
            }

            Console.WriteLine();

            for (int i = 0; i < n; ++i)
            {
                if (zero[i])
                {
                    Console.Write("{0}: ", i);

                    for (int j = 0; j < m; ++j)
                    {
                        Console.Write("{0} ", array[i][j]);
                    }

                    Console.WriteLine();
                }
            }            
        }
    }
}
