Console.Write("Введите целое число больше единицы: ");
int number = int.Parse(Console.ReadLine());

if (number < 2) Console.WriteLine("Не подходит по условию :)");
else if (number >= 2)
{
    Console.Write($"{number} -> ");

    int count = 1;

    while (count < number + 1)
    {
        if (count % 2 == 0) Console.Write($"{count} ");
        count += 1;
    }
}