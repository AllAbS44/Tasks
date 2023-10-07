int SecondDigit(int numb)
{
    return (numb % 100) / 10;
}

Console.Write("Введите трёхзначное число: ");
int number1 = int.Parse(Console.ReadLine());

if ((number1 < 1000) && (number1 > 99)) Console.WriteLine($"{number1} -> {SecondDigit(number1)}");
else if ((number1 < -99) && (number1 > -1000)) Console.WriteLine($"{number1} -> {SecondDigit(number1) * -1}");
else Console.WriteLine("Число не трёхзначное");