﻿/*Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

6 -> да
7 -> да
1 -> нет */

Console.WriteLine("Введите число дня недели");
int a = int.Parse(Console.ReadLine());
if (a < 6) {Console.WriteLine("это не выходной, убираем бухло");}
if (a > 5 && a < 8) {Console.WriteLine("это выходной, пора бухать");}