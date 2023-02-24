Console.Write("Введите целое число.");

int inValue = Convert.ToInt32(Console.ReadLine());
int number = 1;

while (number <= inValue)
{
    if (number % 2 == 0)
    {
        Console.WriteLine(number);
    }
    number++;
}