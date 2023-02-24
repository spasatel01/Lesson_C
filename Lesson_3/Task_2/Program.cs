int InputInt(string massage)
{
    System.Console.Write($"{massage} >");
    int value;
    if (int.TryParse(Console.ReadLine(), out value))
    {
        return value;
    }
    System.Console.WriteLine("Вы ввели не число");
    Environment.Exit(1);
    return 0;
}


(int x, int y, int z) ThreeCoordinatePoints(string massage)
{
    System.Console.WriteLine($"{massage}");
    int x = InputInt("X");
    int y = InputInt("Y");
    int z = InputInt("Z");
    return (x, y, z);
}

double Distance((int x, int y, int z) pointOne, (int x, int y, int z) pointTwo)
{
    double distance = Math.Sqrt(Math.Pow((pointTwo.x - pointOne.x), 2) + Math.Pow((pointTwo.y - pointOne.y), 2) + Math.Pow((pointTwo.z - pointOne.z), 2));
    return distance;
}

var pointA = ThreeCoordinatePoints("Введи координаты точки А по координатам X,Y,Z.");
var pointB = ThreeCoordinatePoints("Введи координаты точки B по координатам X,Y,Z.");

System.Console.WriteLine($"Расстояние между указанными точками А и В состовляет {Distance(pointA, pointB):F2}");