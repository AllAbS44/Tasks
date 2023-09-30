Console.Write("Введите первое число: ");
int a = int.Parse(Console.ReadLine());

Console.Write("Введите второе число: ");
int b = int.Parse(Console.ReadLine());

Console.Write("Введите третье число: ");
int c = int.Parse(Console.ReadLine());

if (a > b && a > c) Console.WriteLine($"a = {a}; b = {b}; c = {c} -> max = {a}");
else if (b > a && b > c) Console.WriteLine($"a = {a}; b = {b}; c = {c} -> max = {b}");
else if (c > a && c > b) Console.WriteLine($"a = {a}; b = {b}; c = {c} -> max = {c}");
else if (a == b && a > c) Console.WriteLine($"a = {a}; b = {b}; c = {c} -> max = {a}");
else if (a == c && a > b) Console.WriteLine($"a = {a}; b = {b}; c = {c} -> max = {a}");
else if (b == c && b > a) Console.WriteLine($"a = {a}; b = {b}; c = {c} -> max = {b}");