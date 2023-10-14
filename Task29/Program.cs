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

Console.Write("Введите длину массива: ");
int length = int.Parse(Console.ReadLine());

int[] result = RandomArray(0, 50, 8);

PrintArray(result);
Console.Write(" -> [");
PrintArray(result);
Console.Write("]");