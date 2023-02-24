System.Console.WriteLine("Введите целое число.");

string inValue;

inValue = Console.ReadLine();

int value = Convert.ToInt32(inValue);

if (value % 2 == 0)
{

    System.Console.WriteLine($"Число {value} , является четным.");
}
else
{
    System.Console.WriteLine($"Число {value} , не является четным.");
}