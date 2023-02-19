//Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

//456 -> 5
//782 -> 8
//918 -> 1

Console.Clear();
Console.WriteLine("Введите трехзначное число");
int a = int.Parse(Console.ReadLine());
int b = a / 10;
int c = b % 10;
Console.WriteLine($"{c} ");
