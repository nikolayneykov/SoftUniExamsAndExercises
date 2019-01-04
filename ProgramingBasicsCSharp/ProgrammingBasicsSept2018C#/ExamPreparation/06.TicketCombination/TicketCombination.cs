using System;

class TicketCombination
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        for (char i1 = 'B'; i1 <= 'L'; i1++)
            for (char i2 = 'f'; i2 >= 'a'; i2--)
                for (char i3 = 'A'; i3 <= 'C'; i3++)
                    for (int i4 = 1; i4 <= 10; i4++)
                        for (int i5 = 10; i5 >= 1; i5--)
                        {
                            if (i1 % 2 == 0)
                            {
                                n--;
                            }
                            if (n == 0)
                            {
                                string combination = $"{i1}{i2}{i3}{i4}{i5}";
                                int price = i1 + i2 + i3 + i4 + i5;
                                Console.WriteLine($"Ticket combination: {combination}\nPrize: {price} lv.");
                                return;
                            }
                        }
    }
}

