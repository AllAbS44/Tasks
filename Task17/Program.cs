int Quarter(int x, int y)
{
    if (x > 0 && y > 0) return 1;
    if (x < 0 && y > 0) return 2;
    if (x < 0 && y < 0) return 3;
    if (x > 0 && y < 0) return 4;
    return 0;
}

Console.WriteLine("Введите координаты точек");

Console.Write("X: ");
int xCoordinate = int.Parse(Console.ReadLine());

Console.Write("Y: ");
int yCoordinate = int.Parse(Console.ReadLine());

int quater = Quarter(xCoordinate, yCoordinate);

string result = quater > 0 
                ? $"Указанные координаты соответствуют четверти {quater}" 
                : "Необходимо ввести координаты отличные от нуля";

Console.WriteLine(result);