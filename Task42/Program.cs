int DecToBin(int num)
{
    int res = 0;
    int i = 1;
    while(num > 0)
    {
        res += num % 2 * i;
        num /= 2;
        i *= 10;
    }
    return res;
}

Console.WriteLine("Введите целое число: ");
int number = int.Parse(Console.ReadLine());

int result = DecToBin(number);

Console.WriteLine(result);