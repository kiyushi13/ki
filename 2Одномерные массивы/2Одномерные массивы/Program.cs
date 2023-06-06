namespace _2Одномерные_массивы
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите кол-во чисел для формирования случайного массива:");
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            Random rand = new Random();
            for (int i = 0; i < n; i++)
            {
                arr[i] = rand.Next(15);
                Console.WriteLine(i + ")" + arr[i]);
            }
            Console.WriteLine(CheckArray(arr));
            Console.ReadKey();
        }

        static int CheckArray(int[] a)
        {
            for (int i = 0; i < a.Length - 1; i++)
                if ((a[i] + a[i + 1]) % 2 == 0)
                    return i + 1;
            return 0;
        }
    }
}