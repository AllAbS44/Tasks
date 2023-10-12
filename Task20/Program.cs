double PointsDistance(int x1, int y1, int x2, int y2)
{
    double X = Math.Pow((x2 - x1), 2);
    double Y = Math.Pow((y2 - y1), 2);
    double distance = Math.Sqrt (X + Y);
    return Math.Round(distance, 2, MidpointRounding.ToZero);
}

Console.WriteLine("Введите координаты точки А");
Console.Write("x: ");
int xA = int.Parse(Console.ReadLine());
Console.Write("y: ");
int yA = int.Parse(Console.ReadLine());

Console.WriteLine("Введите координаты точки B");
Console.Write("x: ");
int xB = int.Parse(Console.ReadLine());
Console.Write("y: ");
int yB = int.Parse(Console.ReadLine());

double result = PointsDistance(xA, yA, xB, yB);

Console.WriteLine($"A ({xA},{yA}); B({xB},{yB}) -> {result}");