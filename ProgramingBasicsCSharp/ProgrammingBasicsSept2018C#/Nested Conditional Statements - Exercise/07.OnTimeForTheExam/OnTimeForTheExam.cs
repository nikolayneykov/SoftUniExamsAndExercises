using System;
using System.Text;

class OnTimeForTheExam
{
    static void Main(string[] args)
    {
        int examHour = int.Parse(Console.ReadLine());
        int examMinute = int.Parse(Console.ReadLine());
        int arrivalHour = int.Parse(Console.ReadLine());
        int arrivalMinute = int.Parse(Console.ReadLine());

        TimeSpan examTime = new TimeSpan(examHour, examMinute, 0);
        TimeSpan arrivalTime = new TimeSpan(arrivalHour, arrivalMinute, 0);
        int timeDifference = (int)(examTime.TotalMinutes - arrivalTime.TotalMinutes);

        string result = "";
        if (timeDifference >= 0 && timeDifference <= 30)
        {
            result = "On time";
            result += timeDifference > 0 ? $"\n{timeDifference} minutes before the start" : "";
        }
        else if (timeDifference < 0)
        {
            result = "Late";
            result += Math.Abs(timeDifference) >= 60 ?
             $"\n{Math.Abs(timeDifference / 60)}:${Math.Abs(timeDifference % 60):D2} hours after the start" :
             $"\n{Math.Abs(timeDifference)} minutes after the start";
        }
        else if (timeDifference > 30)
        {
            result = "Early";
            result += Math.Abs(timeDifference) >= 60 ?
             $"\n{Math.Abs(timeDifference / 60)}:${Math.Abs(timeDifference % 60):D2} hours before the start" :
             $"\n{Math.Abs(timeDifference)} minutes before the start";
        }
        Console.WriteLine(result);
    }
}

