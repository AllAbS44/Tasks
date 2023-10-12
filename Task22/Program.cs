void TableSquare(int number) 
{
    for (int i = 1; i < number + 1; i++) Console.WriteLine($"{i, 3} -> {Math.Pow(i, 2), 5}");
}

Console.WriteLine("Введите число N");
Console.Write("N: ");
int N = int.Parse(Console.ReadLine());

TableSquare(N);