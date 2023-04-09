/*Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30*/


using System;
using static System.Console;

WriteLine("Задача №66");
WriteLine();

int SumNumbers (int n){
    if(n == 0) return 0;
    else return n + SumNumbers(n - 1);
}

Write("Введите число: ");
int num = int.Parse(ReadLine()!);

WriteLine();
WriteLine($"Сумма чисел от 1 до {num} -> {SumNumbers(num)}");

WriteLine();
