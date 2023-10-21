double SearchX(double b1, double k1, double b2, double k2)
{
    double X = (b2 - b1) / (k1 - k2);
    return X;
}

double SearchY(double b1, double k1, double X)
{
    double Y = k1 * X + b1;
    return Y;
}

Console.Write("Введите b1: ");
double b1 = int.Parse(Console.ReadLine());

Console.Write("Введите k1: ");
double k1 = int.Parse(Console.ReadLine());

Console.Write("Введите b2: ");
double b2 = int.Parse(Console.ReadLine());

Console.Write("Введите k2: ");
double k2 = int.Parse(Console.ReadLine());

double x = SearchX(b1, k1, b2, k2);

double y = SearchY(b1, k1, x);

Console.WriteLine($"b1 = {b1}, k1 = {k1}, b2 = {b2}; k2 = {k2} -> ({x};{y})");