using System;

class Choreography
{
    static void Main(string[] args)
    {
        double numberOfSteps = double.Parse(Console.ReadLine());
        double numberOfDancers = double.Parse(Console.ReadLine());
        double daysForLearning = double.Parse(Console.ReadLine());
        double percentStepsPerDay =
            Math.Ceiling(((numberOfSteps / daysForLearning) / numberOfSteps) * 100);
        double percentStepsPerDancer = percentStepsPerDay / numberOfDancers;
        Console.WriteLine(percentStepsPerDay > 13 ?
            "No, They will not succeed in that goal! Required {0:F2}% steps to be learned per day." :
            "Yes, they will succeed in that goal! {0:F2}%.", percentStepsPerDancer);
    }
}

