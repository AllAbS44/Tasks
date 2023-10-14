int SumNumber(int numb)
{
    int count = 0;
    while (numb != 0)
    {
        count += numb % 10;
        numb /= 10;
    }
    return count;
}

Console.Write("Введите целое число: ");
int number = int.Parse(Console.ReadLine());

Console.WriteLine($"{number} -> {SumNumber(number)}");