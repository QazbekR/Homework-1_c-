/*Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

[345, 897, 568, 234] -> 2*/

Console.Clear();
Console.WriteLine("Вот массив из 12  трехзначных элементов:");
int[] startArray = GetArray(12, 100, 1000);
Console.WriteLine(String.Join(", ", startArray));
Console.WriteLine($"количество четных элементов = {chet(startArray)}");
int[] GetArray(int a, int min, int max) 
{
    int[] result = new int[a];
    for (int i = 0; i < a; i++) 
    { 
        result[i] = new Random().Next(min, max);
    }
    return result;
}

int chet(int[] array)
{
    int count = 0;
    foreach(int el in array) {
        if (el % 2 == 0)
        count ++;
    }
    return count;
}
