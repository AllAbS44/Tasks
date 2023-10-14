int[] RandomArray (int min, int max, int length)
{
    int[] arr = new int[length];
    var rnd = new Random();
    for (int i = 0; i < length; i++)
    {
        arr[i] = rnd.Next(min, max + 1);
    }
    return arr;
}

void PrintArray(int[] mas)
{
    int i = 0;
    while (i < mas.Length - 1)
    {
        Console.Write(mas[i] + ", ");
        i++;
    }
    Console.Write(mas[i]);
}

int[] GetSumPositiveNegativeNumber(int[] arr)
{
    int sumPositive = 0;
    int sumNegative = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0)
        {
            sumPositive += arr[i];
        }
        if (arr[i] < 0)
        {
            sumNegative += arr[i];
        }
    }
    return new int[] {sumPositive, sumNegative};
}

Console.Write("Введите длину массива: ");
int length = int.Parse(Console.ReadLine());

int[] result = RandomArray(-9, 9, length);

PrintArray(result);
Console.Write(" -> [");
PrintArray(result);
Console.Write("]");
Console.WriteLine();

int[] SumPositiveNegativeNumber = GetSumPositiveNegativeNumber(result);

Console.WriteLine($"Сумма положительных чисел -> {SumPositiveNegativeNumber[0]}");
Console.WriteLine($"Сумма отрицательных чисел -> {SumPositiveNegativeNumber[1]}");