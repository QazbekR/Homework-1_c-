Console.Clear();
Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine());
if (number%2==0) {Console.WriteLine($"{number} это четное число");}
else {Console.WriteLine($"{number} это нечетное число");}
