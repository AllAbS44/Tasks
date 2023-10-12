string Coordinate(int quater)
{
    if (quater == 1) return "x > 0, y > 0";
    if (quater == 2) return "x < 0, y > 0";
    if (quater == 3) return "x < 0, y < 0";
    if (quater == 4) return "x > 0, y < 0";
    return null;
}

Console.WriteLine("Введите номер четверти");

Console.Write("Номер четверти: ");
int quater = int.Parse(Console.ReadLine());

string Quadro = Coordinate(quarter);

string result = Quadro != null
                ? $"Указанная четверть соответствует координатам {Quadro}"
                : $"Данной области не существует";

Console.WriteLine(result);