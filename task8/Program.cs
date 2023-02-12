Console.Clear();
Console.WriteLine("Введите число: ");
int a = int.Parse(Console.ReadLine());
int b = 2;
while(b<a+1) {Console.Write($"{b} ");
    b = b + 2;}
