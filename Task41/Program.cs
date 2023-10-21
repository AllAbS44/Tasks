int[] FillingArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write("Введите число: ");
        arr[i] = int.Parse(Console.ReadLine());
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

int NumbersAboveZero(int[] arr)
{
    int res = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if(arr[i] > 0) res += 1;
    }
    return res;
}

Console.Write("Введите количество чисел: ");
int length = int.Parse(Console.ReadLine());

int[] array = new int[length];

array = FillingArray(array);

int result = NumbersAboveZero(array);

PrintArray(array);
Console.WriteLine($" -> {result}");