

int Promt(string massege)
{
    System.Console.Write($"{massege} >");
    return Convert.ToInt32(Console.ReadLine());
}

int number = Promt("Введите трех значное число");

if (number >= 100 && number < 1000)
{
    int lastNumber = ((number / 10) % 10);
    System.Console.WriteLine($"Вторая цифра числа {number}, равна {lastNumber}");
}
else 
{
    System.Console.WriteLine("Вы ввели не трехзначное число");
}


    



