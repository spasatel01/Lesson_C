int Request(string massege)
{
    System.Console.Write($"{massege} >");
    return Convert.ToInt32(Console.ReadLine());
}

int SecondNumber(int number)
{
    while (number >= 999)
    {
        number = number / 10;
    }
    number = number % 10;
    return number;
}

int number = Request("Введите трехзначное число");

int secondNumber = SecondNumber(number);

if (number < 100)
{
    System.Console.WriteLine("Вы ввели двухзначное число");
}
else
{
    System.Console.WriteLine($"Третья цифра введеного числа > {SecondNumber(number)}");
}

