int Degree(int A, int B)
{
    int number = 1;
    for (int i = 0; i < B; i++)
    {
        number *= A;
    }
    return number;
}

Console.Write("Введите целое число A: ");
int A = int.Parse(Console.ReadLine());

Console.Write("Введите целое положительное число B: ");
int B = int.Parse(Console.ReadLine());

Console.WriteLine($"{A}, {B} -> {Degree(A, B)}");