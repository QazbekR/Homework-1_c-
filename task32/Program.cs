/* **Задача 32:**Напишите программу замена элементов массива:
положительные элементы замените на соответствующие отрицательные, и наоборот.

[-4, -8, 8, 2] -> [4, 8, -8, -2]*/

Console.Clear();
Console.WriteLine("Вот массив из 6 элементов:");
int[] startArray = GetArray(6, -9, 10);
Console.WriteLine(String.Join(", ", startArray));
Console.WriteLine("А вот его обратная версия:");
Console.WriteLine(String.Join(", ", inverse(startArray)));

int[] GetArray(int a, int min, int max) 
{
    int[] result = new int[a];
    for (int i = 0; i < a; i++) 
    { 
        result[i] = new Random().Next(min, max);
    }
    return result;
}

int[] inverse(int[] array)
{
    for(int i = 0; i < array.Length; i++) 
    {
        array[i] *= -1;
    };
    return array;
}

