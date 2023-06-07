namespace _5Строки
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите строку S: ");
            string s = Console.ReadLine();

            Console.Write("Введите строку S1: ");
            string s1 = Console.ReadLine();

            Console.Write("Введите строку S2: ");
            string s2 = Console.ReadLine();

            string result = s.Replace(s1, s2); // замена вхождений строки S1 на строку S2 в строке S

            Console.WriteLine("Результат: " + result);
        }
    }
}