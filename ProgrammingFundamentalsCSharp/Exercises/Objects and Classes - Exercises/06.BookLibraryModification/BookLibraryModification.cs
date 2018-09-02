using System;
using System.Collections.Generic;
using System.Linq;
using System.Globalization;
namespace _06.BookLibraryModification
{
    class BookLibraryModification
    {
        static void Main(string[] args)
        {
            List<Title> titles = new List<Title>();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] inputTokens = Console.ReadLine().Split();
                string title = inputTokens[0];
                string date = inputTokens[3];
                titles.Add(new Title()
                {
                    Name = title,
                    Date = DateTime.ParseExact(date, "dd.MM.yyyy", CultureInfo.InvariantCulture)
                });
            }
            DateTime dateToPrintAfter = DateTime.ParseExact(Console.ReadLine(), "dd.MM.yyyy", CultureInfo.InvariantCulture);
            foreach (var title in titles.Where(t => t.Date > dateToPrintAfter).OrderBy(t => t.Date).ThenBy(t => t.Name))
            {
                Console.WriteLine($"{title.Name} -> {title.Date.ToString("dd.MM.yyyy")}");
            }
        }
    }
    class Title
    {
        public string Name { get; set; }
        public DateTime Date { get; set; }
    }
}
