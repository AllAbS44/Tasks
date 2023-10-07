Console.Write("Введите первое число: ");
int number1 = int.Parse(Console.ReadLine());

Console.Write("Введите второе число: ");
int number2 = int.Parse(Console.ReadLine());

bool Multiple(int numb1, int numb2)
{
    return ((numb1 % numb2 ==0) || (numb2 % numb1 == 0));
}

bool result = Multiple(number1, number2);

Console.WriteLine(result ? $"{number1}, {number2} -> Да" : $"{number1}, {number2} -> Нет");