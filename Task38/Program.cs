void PrintArray(double[] mas)
{
    int i = 0;
    while (i < mas.Length - 1)
    {
        Console.Write(mas[i] + ", ");
        i++;
    }
    Console.Write(mas[i]);
}

double[] DifferenceMaxMin(double[] arr)
{
    double max = 0;
    double min = 1000;
    double[] res = new double[2];
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > max) max = arr[i];
        if (arr[i] < min) min = arr[i];
    }
    res[0] = max;
    res[1] = min;
    return res;
}

Console.Write("Введите длину массива: ");
int length = int.Parse(Console.ReadLine());

double[] array = new double[length];

Console.WriteLine("Вводите переменные:");
for (int i = 0; i < array.Length; i++)
{
    array[i] = double.Parse(Console.ReadLine());
}

Console.Write("[");
PrintArray(array);
Console.Write("]");
Console.Write(" => ");

double[] result = DifferenceMaxMin(array);

Console.WriteLine($"{result[0]} - {result[1]} = {result[0] - result[1]}");