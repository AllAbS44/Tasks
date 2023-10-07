Console.Write("Введите номер дня недели: ");
int number = int.Parse(Console.ReadLine());

if ((number < 1) || (number > 7)) Console.WriteLine("Нет такого дня недели");
else if ((number >= 1) && (number <= 5)) Console.WriteLine($"{number} -> не выходной");
else Console.WriteLine($"{number} -> выходной");