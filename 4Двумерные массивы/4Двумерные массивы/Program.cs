namespace _4Двумерные_массивы_
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 3; // размерность матрицы
            int[,] a = new int[n, n]; // создание матрицы
            Random rnd = new Random();
            for (int i = 0; i < n; i++)  // заполнение матрицы случайными числами от -10 до 10
            {
                for (int j = 0; j < n; j++)
                {
                    a[i, j] = rnd.Next(-10, 11);
                }
            }  
            for (int i = 0; i < n; i++) // замена отрицательных элементов на 0, а положительных на 1
            {
                for (int j = 0; j < n; j++)
                {
                    if (a[i, j] < 0)
                    {
                        a[i, j] = 0;
                    }
                    else
                    {
                        a[i, j] = 1;
                    }
                }
            }
            for (int i = 0; i < n; i++)        // вывод нижней треугольной матрицы
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write(a[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }

}