Console.Write("Введите первое число: ");
int a = int.Parse(Console.ReadLine());

Console.Write("Введите второе число: ");
int b = int.Parse(Console.ReadLine());

if (a > b) Console.WriteLine($"a = {a}; b = {b} -> max = {a}, min = {b}");
else if (a < b) Console.WriteLine($"a = {a}; b = {b} -> max = {b}, min = {a}");
else Console.WriteLine($"a = {a}; b = {b} -> max = min = {a}");