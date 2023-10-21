bool IsExistTriangle(int first, int second, int third)
{
    return first < second + third
        && second < first + third
        && third < first + second;
}

Console.Write("Введите длину первой стороны: ");
int length1 = int.Parse(Console.ReadLine());

Console.Write("Введите длину второй стороны: ");
int length2 = int.Parse(Console.ReadLine());

Console.Write("Введите длину третьей стороны: ");
int length3 = int.Parse(Console.ReadLine());

bool result = IsExistTriangle(length1, length2, length3);

Console.WriteLine(result ? "Такой треугольник существует" : "Такого треугольника не существует");