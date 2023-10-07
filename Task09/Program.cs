int number = new Random().Next(10, 100);

Console.WriteLine($"Случайное числа из отрезка [10, 99] -> {number}");

// int FirstDigit = number / 10;
// int SecondDigit = number % 10;
// if (FirstDigit > SecondDigit) Console.WriteLine($"Наибольшая цифра числа -> {FirstDigit}");
// else Console.WriteLine($"Наибольшая цифра числа -> {SecondDigit}");

int MaxDigit(int num)
{
    int FirstDigit = num / 10;
    int SecondDigit = num % 10;
    return FirstDigit > SecondDigit ? FirstDigit : SecondDigit;
}

Console.WriteLine($"Наибольшая цифра числа -> {MaxDigit(number)}");