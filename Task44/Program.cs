int[] FiboArray(int num)
{
    int[] arr = new int[num];
    arr[1] = 1;
    for (int i = 2; i < arr.Length; i++)
    {
        arr[i] = arr[i - 1] + arr[i - 2];
    }
    return arr;
}

void PrintArray(int[] mas)
{
    int i = 0;
    while (i < mas.Length - 1)
    {
        Console.Write(mas[i] + " ");
        i++;
    }
    Console.Write(mas[i]);
}

Console.WriteLine("Введите целое число больше единицы: ");
int length = int.Parse(Console.ReadLine());

if(length < 2)
{
    Console.WriteLine("Некорректный ввод.");
    return;
}

int[] array = FiboArray(length);

Console.Write($"Если N = {length} -> ");
PrintArray(array);