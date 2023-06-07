namespace _6Работа_с_файлами
{
    using System;
    using System.IO;
    using System.Linq;
    class Program
    {
        static void Main(string[] args)
        {
            string filename = "text.txt"; // имя файла с текстом
            string text = File.ReadAllText(filename); // чтение текста из файла

            // разделители слов
            char[] separators = new char[] { ' ', '.', ',', '!', '?', ':', ';', '(', ')', 'n', 'r', 't' };

            // разбиение текста на слова
            string[] words = text.Split(separators, StringSplitOptions.RemoveEmptyEntries);

            // подсчет количества слов различной длины
            int[] counts = new int[11];
            foreach (string word in words)
            {
                int length = word.Length;
                if (length <= 10)
                {
                    counts[length]++;
                }
                else
                {
                    counts[10]++;
                }
            }
            // вывод слов в порядке возрастания их длины
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("Слова длины " + i + ":");
                var wordsOfLength = words.Where(w => w.Length == i).OrderBy(w => w);
                foreach (string word in wordsOfLength)
                {
                    Console.WriteLine(word);
                }
                Console.WriteLine("Количество слов длины " + i + ": " + counts[i]);
                Console.WriteLine();
            }

            Console.WriteLine("Слова длины более 10 символов:");
            var longWords = words.Where(w => w.Length > 10).OrderBy(w => w);
            foreach (string word in longWords)
            {
                Console.WriteLine(word);
            }
            Console.WriteLine("Количество слов длины более 10 символов: " + counts[10]);
        }
    }


}