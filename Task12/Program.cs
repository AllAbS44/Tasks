Console.Write("Введите первое число: ");
int number1 = int.Parse(Console.ReadLine());

Console.Write("Введите второе число: ");
int number2 = int.Parse(Console.ReadLine());

void Multiple(int num1, int num2)
{
    if (num1 % num2 == 0) Console.WriteLine($"{num1}, {num2} -> кратно");
    else Console.WriteLine($"{num1}, {num2} -> не кратно, остаток {num1 % num2}");
}

Multiple(number1, number2);