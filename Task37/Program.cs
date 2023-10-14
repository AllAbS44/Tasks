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

int[] ProductOfNums(int[] arr)
{
    int size = arr.Length / 2;
    if (arr.Length % 2 != 0) size += 1;
    int[] result = new int[size];
    for (int i = 0; i < size; i++)
    {
        if (i == arr.Length - 1 - i) result[i] = arr[i];
        else result[i] = arr[i] * arr[arr.Length - 1 - i];
    }
    return result;
}

Console.Write("Введите длину массива: ");
int length = int.Parse(Console.ReadLine());

int[] array = RandomArray(1, 9, length);

Console.Write("[");
PrintArray(array);
Console.Write("]");
Console.Write(" -> ");

int[] arr = ProductOfNums(array);

Console.Write("[");
PrintArray(arr);
Console.Write("]");