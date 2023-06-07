namespace _9Динамические_списки
{
    using System;

    class Painting
    {
        public string Name;
        public string Artist;
        public decimal Price;
        public Painting Next;
    }

    class Gallery
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of paintings: ");
            int n = int.Parse(Console.ReadLine());

            Painting head = null;
            Painting tail = null;

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Enter details for painting {i + 1}:");
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Artist: ");
                string artist = Console.ReadLine();
                Console.Write("Price: ");
                decimal price = decimal.Parse(Console.ReadLine());

                Painting painting = new Painting
                {
                    Name = name,
                    Artist = artist,
                    Price = price
                };

                if (head == null)
                {
                    head = painting;
                    tail = painting;
                }
                else
                {
                    tail.Next = painting;
                    tail = painting;
                }
            }

            Console.WriteLine("nPaintings in the gallery:");
            Painting current = head;
            while (current != null)
            {
                Console.WriteLine($"Name: {current.Name}");
                Console.WriteLine($"Artist: {current.Artist}");
                Console.WriteLine($"Price: {current.Price}");
                Console.WriteLine();
                current = current.Next;
            }

            Console.Write("Enter a search keyword: ");
            string keyword = Console.ReadLine();

            Console.WriteLine($"nPaintings containing '{keyword}' in their name:");
            current = head;
            while (current != null)
            {
                if (current.Name.Contains(keyword))
                {
                    Console.WriteLine($"Name: {current.Name}");
                    Console.WriteLine($"Artist: {current.Artist}");
                    Console.WriteLine($"Price: {current.Price}");
                    Console.WriteLine();
                }
                current = current.Next;
            }
        }
    }

}