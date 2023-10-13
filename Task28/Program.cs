int Multiply(int number)
{
    int mult = 1;
    for (int i = 1; i <= number; i++)
    {
        mult *= i;
    }
    return mult;
}

Console.WriteLine("Введите целое положительное число");
Console.Write("N: ");
int N = int.Parse(Console.ReadLine());

Console.WriteLine($"{N} -> {Multiply(N)}");