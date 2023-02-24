int InputInt(string massage)
{
    System.Console.WriteLine($"{massage}");
    int value;
    if (int.TryParse(Console.ReadLine(), out value))
    {
        return value;
    }
    System.Console.WriteLine("Вы ввели не число");
    Environment.Exit(1);
    return 0;
}

int ReversNumbers(int value)
{
    int number = 0;
    while (value > 0)
    {
        number = number * 10 + value % 10;
        value = value / 10;
    }
    return number;
}

int number = InputInt("Введите число.");

if (number == ReversNumbers(number))
{
    System.Console.WriteLine($" Введеное число {number}  является палиндромом.");
}
else
{
    System.Console.WriteLine($"Введеное число {number}  не является палиндромом.");
}

