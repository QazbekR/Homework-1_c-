/*Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29*/

using System;
using static System.Console;

WriteLine("Задача №68");
WriteLine();

int Akkerman (int a, int b){
    if(a == 0) return b + 1;
    else if(b == 0) return Akkerman(a - 1, 1);
    else return Akkerman(a - 1, Akkerman(a, b - 1));
}

Write("Введите первое число: ");
int n1 = int.Parse(ReadLine()!);

Write("Введите второе число: ");
int n2 = int.Parse(ReadLine()!);

WriteLine($"Функция Аккермана: {Akkerman(n1,n2)}");
