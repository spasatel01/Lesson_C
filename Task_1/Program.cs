int a = 5;
int b = 7;
int max = 0;
int min = 0;
if (a > b)
{
    max = a;
    min = b;
}
else
{
    max = b;
    min = a;
}

System.Console.WriteLine($"Минимальное число {min}, а максимальное число {max}.");
