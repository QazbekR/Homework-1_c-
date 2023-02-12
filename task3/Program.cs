Console.Clear();
Console.Write("Введите первое число: ");
int a = int.Parse(Console.ReadLine());
Console.Write("Введите второе число: ");
int b = int.Parse(Console.ReadLine());
Console.Write("Введите третье число: ");
int c = int.Parse(Console.ReadLine());
if(a>b && a>c) {Console.WriteLine($"Max = {a}");}
if(b>a && b>c) {Console.WriteLine($"Max = {b}");}
if(c>b && c>a) {Console.WriteLine($"Max = {c}");}
if(a==b && b==c && a==c) {Console.WriteLine("Такого не может быть");}