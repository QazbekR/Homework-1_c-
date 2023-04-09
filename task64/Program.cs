/* Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"*/

using System;
using static System.Console;

WriteLine("Задача №64");
WriteLine();

string PrintNumbers (int m, int n){
    if(m == n) return m.ToString();
    string str = m.ToString() + " " + PrintNumbers(m - 1, n) ;
    return str;
}

Write("Введите первое число: ");
int number1 = int.Parse(ReadLine()!);

Write("Введите второе число: ");
int number2 = Convert.ToInt32(ReadLine());

WriteLine($"Все числа в диапазоне ({number1}, {number2}) -> {PrintNumbers(number1, number2)}");

WriteLine();