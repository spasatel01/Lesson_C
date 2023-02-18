int Request(string massege)
{
    System.Console.Write($"{massege} >");
    return Convert.ToInt32(Console.ReadLine());
}

bool Weekend(int day)
{
    if (day > 5 && day <= 7)
    {
        return true;
    }
    return false;
}

bool ValidateDay(int day)
{
    if (day > 0 && day <= 7)
    {
        return true;
    }
    System.Console.WriteLine("Число больше чем дней в недели");
    return false;
}

int day = Request("Введите день недели");

if (ValidateDay(day))
{
    if (Weekend(day))
    {
        System.Console.WriteLine("Сегодня выходной");
    }
    else
    {
        System.Console.WriteLine("Сегодня не выходной");
    }
}


