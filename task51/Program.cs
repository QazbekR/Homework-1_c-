using System;
using static System.Console;

Clear();

Write("Введите количество строк:");
int rows = int.Parse(ReadLine());

Write("Введите количество столбцов:");
int columns = int.Parse(ReadLine());

int[,] array = GetArray(rows, columns, 0, 10);
PrintArray(array);
WriteLine($"Сумма главной диагонали равна {diog(array)}");
int[,] GetArray(int m, int n, int min, int max)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result [i, j] = new Random().Next(min, max);
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

int diog(int[,] array)
{
    int length = array.GetLength(0) < array.GetLength(1) ? array.GetLength(0) : array.GetLength(1);
    // if (array.GetLength(0) < array.GetLength(1))
    //      length = array.GetLength(0);
    // else
    //      length = array.GetLength(1);
    int sum = 0;
    for (int i = 0; i < length; i++)
    {   
        sum += array[i, i];
    }
    return sum;
}

/*int sum = 0;
for (int i = 0; i < array.GetLength(0); i++)
{   
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (i == j)
            {
                sum = sum + array[i, j];
            }
        }
}

WriteLine($"Сумма диагонали равна {sum}");*/ //это мое решение, в принципе правильное
    