using System;

class OldBooks
{
    static void Main(string[] args)
    {
        string bookName = Console.ReadLine();
        int libraryCapacity = int.Parse(Console.ReadLine());
        int checkedBooksCount = 0;
        string input = string.Empty;
        while (checkedBooksCount < libraryCapacity && (input = Console.ReadLine()) != bookName)
        {
            checkedBooksCount++;
        }
        Console.WriteLine(input == bookName ?
            $"You checked {checkedBooksCount} books and found it." :
            $"The book you search is not here!\nYou checked {checkedBooksCount} books.");
    }
}

