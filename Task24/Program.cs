int Sum(int number)
{
    int sum = 0;
    for (int i = 1; i < number + 1; i++)
    {
        sum += i;
    }
    return sum;
}

Console.WriteLine("Введите целое положительное число");
Console.Write("A: ");
int A = int.Parse(Console.ReadLine());

Console.WriteLine($"{A} -> {Sum(A)}");