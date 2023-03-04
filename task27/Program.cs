/* Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

452 -> 11
82 -> 10
9012 -> 12*/

/*Console.Clear();
Console.WriteLine("Введите число");
int a = int.Parse(Console.ReadLine());
int sum = 0;
int num = a;
while (num > 0) 
{
    sum += num % 10;
    num = num / 10;   
}
Console.WriteLine($"Сумма цифр числа {a} равна {sum}");*/

Console.Clear();
Console.WriteLine("Введите число");
int num = int.Parse(Console.ReadLine());
Console.WriteLine($"Сумма цифр числа {num} равна {sum(num)}");

int sum (int num)
{
    int result = 0;
    while (num > 0)
    {
        result += num % 10;
        num = num / 10;
    }
    return result;
}

