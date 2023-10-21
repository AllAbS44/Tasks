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

int[] CopyArray(int[] arr)
{
    int[] array = new int[arr.Length];
    for (int i = 0; i < arr.Length; i++)
    {
        array[i] = arr[i];
    }
    return array;
}

Console.Write("Введите длину массива: ");
int length = int.Parse(Console.ReadLine());

int[] array = RandomArray(1, 9, length);

Console.Write("[");
PrintArray(array);
Console.Write("]");
Console.Write(" -> ");

int[] arr = CopyArray(array);

Console.Write("[");
PrintArray(arr);
Console.Write("]");