// Задайте двумерный массив размером mxn, заполненный случайными вещественными числами.

using System;
using static System.Console;

Clear();

Write("Введите количество строк:");
int rows = int.Parse(ReadLine());

Write("Введите количество столбцов:");
int columns = int.Parse(ReadLine());

int[,] array = GetArray(rows, columns, -100, 101);
PrintArray(array);
int[,] GetArray(int m, int n, int minV, int maxV)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result [i, j] = new Random().Next(minV / 10, maxV / 10);
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
            Write($"{inArray[i,  j]} ");
        }
        WriteLine(" ");
    }
}