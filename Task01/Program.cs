Console.WriteLine("Введите переменную a: ");
double a = double.Parse(Console.ReadLine());

Console.WriteLine("Введите переменную b: ");
double b = double.Parse(Console.ReadLine());

if (b * b == a) Console.WriteLine($"a = {a}, b = {b} -> Да");
else Console.WriteLine($"a = {a}, b = {b} -> Нет");