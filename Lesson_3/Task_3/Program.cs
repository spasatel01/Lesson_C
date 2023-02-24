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

int number = InputInt("Введите число.");
System.Console.WriteLine("Таблица кубов чисел от 1 до введенного: ");

for (int i = 1; i <= number; i++)
{
    System.Console.WriteLine($"{Math.Pow(i, 3)}");
}