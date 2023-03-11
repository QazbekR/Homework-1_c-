﻿// **Задача 40:**Напишите программу,
// которая принимает на вход три числа и проверяет, может ли
// существовать треугольник с сторонами такой длины.


// ❗ **Теорема о неравенстве треугольника:
// **каждая сторона треугольника меньше суммы двух других сторон.

/*Console.Clear();
Console.WriteLine("Введите первое число");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число");
int b = int.Parse(Console.ReadLine());
Console.WriteLine("Введите третье число");
int c = int.Parse(Console.ReadLine());

if (a < b + c && b < a + c && c < a + b) {
    Console.WriteLine("да это треугольник");
}
else {Console.WriteLine("это не тругольниk");}*/ // первое решение, которое мое

Console.Clear();
Console.WriteLine("Введите стороны через пробел:");

string[] st = Console.ReadLine().Split(' ');
int a = int.Parse(st[0]);
int b = int.Parse(st[1]);
int c = int.Parse(st[2]);

if (IsTriangle (a, b, c)) {Console.WriteLine("Yes");}
else {Console.WriteLine("NO");}

bool IsTriangle(int a, int b, int c) 
{

    return ((a + b > c) && (b + c > a) && (c + a > b));

}
