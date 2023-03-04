/*Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

[3 7 22 2 78] -> 76*/

Console.Clear();
Console.WriteLine("Вот массив из 8  трехзначных элементов:");
int[] startArray = GetArray(15, 1, 101);
Console.WriteLine(String.Join(", ", startArray));
int[] GetArray(int a, int min, int max) 
{
    int[] result = new int[a];
    for (int i = 0; i < a; i++) 
    { 
        result[i] = new Random().Next(min, max);
    }
    return result;
}

double min = Int32.MaxValue;
double max = Int32.MinValue;
for (int z = 0; z < startArray.Length; z++)
{
    if (startArray[z] > max)
        {
            max = startArray[z];
        }
    if (startArray[z] < min)
        {
            min = startArray[z];
        }
}
Console.WriteLine($"всего {startArray.Length} чисел. Максимальное значение = {max}, минимальное значение = {min}");
Console.WriteLine($"Разница между максимальным и минимальным значением = {max - min}");
