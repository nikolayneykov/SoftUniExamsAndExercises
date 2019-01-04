using System;
using System.Text;

class Building
{
    static void Main(string[] args)
    {
        int floors = int.Parse(Console.ReadLine());
        int numberOfPlaces = int.Parse(Console.ReadLine());
        StringBuilder building = new StringBuilder();

        for (int currentFloor = floors; currentFloor >= 1; currentFloor--)
        {
            char placeName = currentFloor == floors ? 'L' : currentFloor % 2 == 1 ? 'A' : 'O';
            for (int currentPlace = 0; currentPlace < numberOfPlaces; currentPlace++)
            {
                building.Append($"{placeName}{currentFloor}{currentPlace} ");
            }
            building.AppendLine();
        }

        Console.WriteLine(building.ToString().TrimEnd());
    }
}

