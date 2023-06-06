namespace _1Структурное_программирование_
{
    class Program
    {
        static int n;
        static int k;
        static int result;

        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("\nМеню программы:");
                Console.WriteLine("1. Ввод данных");
                Console.WriteLine("2. Обработка");
                Console.WriteLine("3. Просмотр результатов");
                Console.WriteLine("4. Выход");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        InputData();
                        break;
                    case "2":
                        ProcessData();
                        break;
                    case "3":
                        ViewResults();
                        break;
                    case "4":
                        Console.WriteLine("Выход из программы...");
                        return;
                    default:
                        Console.WriteLine("Ошибка: неверный номер пункта меню");
                        break;
                }
            }
        }

        static void InputData()
        {
            Console.Write("Введите значение n: ");
            n = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите значение k: ");
            k = Convert.ToInt32(Console.ReadLine());
        }

        static void ProcessData()
        {
            result = 0;
            for (int i = 1; i <= n; i++)
            {
                result += Convert.ToInt32(Math.Pow(i, k));
            }
        }

        static void ViewResults()
        {
            Console.WriteLine("Сумма выражения равна: " + result);
        }
    }
}