
int InputInt(string massage)
{
    System.Console.WriteLine($"{massage}");
    return Convert.ToInt32(Console.ReadLine());
}

int DegreeNumbers(int numberOne, int numberTwo)
{
    int degree = numberOne;

    for (int i = 1; i < numberTwo; i++)
    {
        degree = degree * numberOne;
    }
    return degree;
}

int numberOne = InputInt("Ведите первое число.");
int numberTwo = InputInt("Ведите второе число.");

Console.WriteLine($"Первое введеное число в степени второго введеного числа равно {DegreeNumbers(numberOne, numberTwo)}.");
