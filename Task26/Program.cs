int CountOfNumbers(int numb)
{
    int count = 0;
    while (numb != 0)
    {
        numb /= 10;
        count += 1;
    }
    return count;
}

Console.WriteLine("Введите число");
Console.Write("Number: ");
int number = int.Parse(Console.ReadLine());

Console.WriteLine($"{number} -> {CountOfNumbers(number)}");