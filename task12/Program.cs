﻿// Напишите программу, которая будет принимать на вход два числа и выводить,
//является ли второе число кратным первому. Если второе число не кратно числу первому,
//то программа выводит остаток от деления.
// 34, 5 -> не кратно, остаток 4
// 16, 4 -> кратно;

Console.Clear();
int num1 = new Random().Next(10, 100);
int num2 = new Random().Next(1, 10);
int max = num1 % num2;
if  (max > 0) {Console.WriteLine($"{num1} не кратно {num2}, остаток {max}");}
else {Console.WriteLine($"{num1} кратно {num2}");}
