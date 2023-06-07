namespace _8Структуры
{


    struct Pharmacy
    {
        public string Name;
        public DateTime ProductionDate;
        public int ExpirationDays;

        public Pharmacy(string name, DateTime productionDate, int expirationDays)
        {
            Name = name;
            ProductionDate = productionDate;
            ExpirationDays = expirationDays;
        }

        public override string ToString()
        {
            return $"{Name}, {ProductionDate.ToString("dd.MM.yyyy")}, срок годности: {ExpirationDays} дн.";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите количество записей в базе данных: ");
            int n = int.Parse(Console.ReadLine());

            // создаем базу данных - массив структур "Аптека"
            Pharmacy[] pharmacyDatabase = new Pharmacy[n];

            // заполняем базу данных случайными значениями
            Random random = new Random();
            for (int i = 0; i < n; i++)
            {
                DateTime productionDate = new DateTime(random.Next(2020, 2022), random.Next(1, 13), random.Next(1, 28)); // дата производства в формате "гггг-мм-дд"
                int expirationDays = random.Next(1, 366); // срок годности в днях

                // создаем новую запись в базе данных
                pharmacyDatabase[i] = new Pharmacy($"Лекарство{i + 1}", productionDate, expirationDays);
            }

            // выводим на экран все записи в базе данных
            Console.WriteLine("База данных:");
            foreach (Pharmacy pharmacy in pharmacyDatabase)
            {
                Console.WriteLine(pharmacy);
            }

            // запрашиваем критерий поиска у пользователя
            Console.Write("Введите количество дней до окончания срока годности: ");
            int expirationDaysLeft = int.Parse(Console.ReadLine());

            // выполняем поиск записей по заданному критерию и выводим результат на экран
            Console.WriteLine("Результаты поиска:");
            bool found = false;
            foreach (Pharmacy pharmacy in pharmacyDatabase)
            {
                if ((pharmacy.ExpirationDays - (DateTime.Now - pharmacy.ProductionDate).Days) == expirationDaysLeft)
                {
                    Console.WriteLine(pharmacy);
                    found = true;
                }
            }

            if (!found)
            {
                Console.WriteLine("Ничего не найдено.");
            }
        }
    }

}