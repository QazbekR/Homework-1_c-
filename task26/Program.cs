// // 26 Напишите программу,
// которая принимает на вход число и выдаёт количество цифр в числе.

// 456 -> 3
// 78 -> 2
// 89126 -> 5

Console.Clear();
Console.WriteLine("Введите любое число");
int n = int.Parse(Console.ReadLine());
Console.WriteLine($"количество цифр {CountN(n)}");

int CountN(int n)
{
    int count = 0;
    if (n < 0)
        n *= -1;
    while (n > 0)
    {
        n /= 10;
        count ++;
    }
    return count;
}


