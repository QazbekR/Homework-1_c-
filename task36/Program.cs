/*Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

[3, 7, 23, 12] -> 19

[-4, -6, 89, 6] -> 0*/

Console.Clear();
Console.WriteLine("Вот массив из 8  трехзначных элементов:");
int[] startArray = GetArray(12, 1, 11);
Console.WriteLine(String.Join(", ", startArray));
Console.WriteLine($"сумма нечетных элементов = {chet(startArray)}");
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
    int sum = 0;
    for (int i = 0; i < array.Length; i = i + 2) {
        sum += array[i];
    }
    return sum;
}

