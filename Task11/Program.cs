int number = new Random().Next(100, 1000);
Console.WriteLine($"Случайное трёхзначное число -> {number}");

int DelSecond(int numb)
{
    int firstDigit = (numb / 100);
    int lastDigit = numb % 10;
    return firstDigit * 10 + lastDigit;
}

Console.WriteLine($"Двухзначное число -> {DelSecond(number)}");