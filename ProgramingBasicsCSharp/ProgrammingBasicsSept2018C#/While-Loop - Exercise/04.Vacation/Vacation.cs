using System;

class Vacation
{
    static void Main()
    {
        decimal vacationPrice = decimal.Parse(Console.ReadLine());
        decimal savings = decimal.Parse(Console.ReadLine());
        int passedDays = 0;
        int spendingDaysCount = 0;

        do
        {
            string action = Console.ReadLine();
            decimal money = decimal.Parse(Console.ReadLine());
            if (action == "save")
            {
                savings += money;
                spendingDaysCount = 0;

            }
            else if (action == "spend")
            {
                savings = savings - money < 0 ? 0 : savings - money;
                spendingDaysCount++;
            }
            passedDays++;

        } while (spendingDaysCount < 5 && savings < vacationPrice);

        Console.WriteLine(savings >= vacationPrice ?
            $"You saved the money for {passedDays} days." :
            $"You can't save the money.\n{passedDays}");
    }
}