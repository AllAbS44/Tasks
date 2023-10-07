int ThirdDigit(int numb)
{
    int Third;
    if ((numb < 100) && (numb > -100)) Third = numb;
    else
    {
        if (numb > 0) while (numb > 999) numb /= 10;
        else 
        {
            while (numb < -999) numb /= 10;
            numb *= -1;
        }
        Third = numb % 10;
    }
    return Third;
}

Console.Write("Введите число: ");
int number1 = int.Parse(Console.ReadLine());

if (ThirdDigit(number1) == number1) Console.WriteLine($"{number1} -> третьей цифры нет");
else Console.WriteLine($"{number1} -> {ThirdDigit(number1)}");