Console.Write("Введите трёхзначное число: ");
int number = int.Parse(Console.ReadLine());

if ((number < 1000 && number > 99) || (number < -99 && number > -1000))
{
    int x = number % 100;
    x %= 10;
    Console.WriteLine($"{number} -> {x}");
}
else Console.WriteLine("Число не трёхзначное :)");