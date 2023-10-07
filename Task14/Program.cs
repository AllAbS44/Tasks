Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine());

Console.Write("Введите первый делитель: ");
int divider1 = int.Parse(Console.ReadLine());

Console.Write("Введите второй делитель: ");
int divider2 = int.Parse(Console.ReadLine());

void Multiple(int numb, int div1, int div2)
{
    if ((numb % div1 == 0) && (number % div2 == 0)) Console.WriteLine($"{numb} одновременно кратен {div1} и {div2}");
    else Console.WriteLine($"{numb} не кратен {div1} и {div2} одновременно");
}

Multiple(number, divider1, divider2);