using System;

class OperationsBetweenNumbers
{
    static void Main(string[] args)
    {
        double operand1 = double.Parse(Console.ReadLine());
        double operand2 = double.Parse(Console.ReadLine());
        char action = char.Parse(Console.ReadLine());
        string result = "";

        switch (action)
        {
            case '+':
                result = $"{operand1} + {operand2} = {operand1 + operand2} - ";
                result += (operand1 + operand2) % 2 == 0 ? "even" : "odd";
                break;
            case '-':
                result = $"{operand1} - {operand2} = {operand1 - operand2} - ";
                result += (operand1 - operand2) % 2 == 0 ? "even" : "odd";
                break;
            case '*':
                result = $"{operand1} * {operand2} = {operand1 * operand2} - ";
                result += (operand1 * operand2) % 2 == 0 ? "even" : "odd";
                break;
            case '/':
                if (operand2 == 0)
                {
                    result = $"Cannot divide {operand1} by zero";
                }
                else
                {
                    result = $"{operand1} / {operand2} = {(operand1 / operand2):F2}";
                }
                break;
            case '%':
                if (operand2 == 0)
                {
                    result = $"Cannot divide {operand1} by zero";
                }
                else
                {
                    result = $"{operand1} % {operand2} = {(operand1 % operand2)}";
                }
                break;
        }
        Console.WriteLine(result);
    }
}

