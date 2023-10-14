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

int SumOfElemInOddPos(int[] arr)
{
    int sum = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (i % 2 != 0) sum += arr[i];
    }
    return sum;
}

Console.Write("Введите длину массива: ");
int length = int.Parse(Console.ReadLine());

int[] array = RandomArray(-100, 100, length);

Console.Write("[");
PrintArray(array);
Console.Write("]");
Console.Write(" -> ");

Console.WriteLine(SumOfElemInOddPos(array));