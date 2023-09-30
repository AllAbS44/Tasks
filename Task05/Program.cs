Console.Write("Введите целое число N: ");
int N = int.Parse(Console.ReadLine());

if (N > 0)
{
    int count = -N;
    Console.Write($"{N} -> ");
    while (count < N + 1)
    {
        Console.Write($"{count} ");
        count += 1;
    }
}
else if (N < 0)
{
    int count = -N;
    Console.Write($"{N} -> ");
    while (count > N - 1)
    {
        Console.Write($"{-count} ");
        count -= 1;
    }
}
else Console.WriteLine($"{N} -> {N}");