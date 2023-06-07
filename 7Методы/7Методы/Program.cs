namespace _7Методы
{

    class Program
    {
        static void Main(string[] args)
        {
            string str = "Hello world! This is a test string.";
            char ch = 'd';
            int count = CountWordsEndingWith(str, ch);
            Console.WriteLine($"The number of words ending with '{ch}' is {count}");
        }

        static int CountWordsEndingWith(string str, char ch)
        {
            int count = 0;
            string[] words = str.Split(' ');
            foreach (string word in words)
            {
                if (word.EndsWith(ch.ToString()))
                {
                    count++;
                }
            }
            return count;
        }
    }

}

