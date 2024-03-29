﻿/**Задача 53:** Задайте двумерный массив.
Напишите программу, которая поменяет местами первую и последнюю строку массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
8 4 2 4
5 9 2 3
1 4 7 2*/

using System;
using static System.Console;
Clear();

Write("Ведите количество строк массива:");
int rows = int.Parse(ReadLine());
Write("Ведите количество столбцов массива:");
int columns = int.Parse(ReadLine());
Write("Ведите строку 1:");
int a1 = int.Parse(ReadLine());
Write("Ведите количество строку 2:");
int b1 = int.Parse(ReadLine());

int[,] array = GetArray(rows, columns, 0, 10);
PrintArray(array);
WriteLine();
ChangeRows(array, a1, b1);
PrintArray(array);

int[,] GetArray(int m, int n, int min, int max)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(min, max);
        }
    }
    return result;
}

void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Write($"{inArray[i, j]} ");
        }
        WriteLine();
    }
}

void ChangeRows(int[,] inArray, int a, int b)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        int k = inArray[a - 1, i];
        inArray[a - 1, i] = inArray[b - 1, i];
        inArray[b - 1, i] = k;
    }
}