// //28 Напишите программу, которая принимает на вход число N
//и выдаёт произведение чисел от 1 до N.

//4-> 24
//5-> 120 == 1 * 2 * 3 * 4 * 5

ulong Summy(ulong j)
{
    ulong sum = 1;
    for (ulong i = 1; i <= j; i++)
        sum = sum * i;
     return sum;
}

Console.Clear();
Console.WriteLine("Введите любое число");
ulong j = ulong.Parse(Console.ReadLine());
// Summy(n);
Console.WriteLine($"Умножение всех чисел от 1 до {j} равна {Summy(j)}");



