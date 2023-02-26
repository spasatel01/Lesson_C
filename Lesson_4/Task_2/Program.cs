int InputInt(string massage)
{
    System.Console.WriteLine($"{massage}");
    return Convert.ToInt32(Console.ReadLine());
}

int SumNumbers(int number)
{
    int sumNumber = 0;
    while (number > 0)
    {
        int num = number % 10;
        number = number / 10;
        sumNumber = sumNumber + num;
    }
    return sumNumber;
}

int number = InputInt("Введите целое число.");

Console.WriteLine($"Cумма всех цифр в введенном числе равна: {SumNumbers(number)}.");