namespace _3Методы_сортировки
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            int n = 4;
            double[,] A = new double[n, n];
            Random rand = new Random();
            Console.WriteLine("Исходная матрица:");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    A[i, j] = rand.NextDouble() * 10;
                    Console.Write("{0:F2}t", A[i, j]);
                }
                Console.WriteLine();
            }
            Console.WriteLine("Отсортированная последовательность:");
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (A[j + 1, j] < A[j, j + 1])
                    {
                        double temp = A[j + 1, j];
                        A[j + 1, j] = A[j, j + 1];
                        A[j, j + 1] = temp;
                    }
                }
            }
            for (int i = 1; i < n; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write("{0:00}t", A[i, j]);
                }
            }
        }
    }

}