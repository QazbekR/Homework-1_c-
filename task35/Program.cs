/* **Задача 35:**Задайте одномерный массив из 123 случайных чисел.
Найдите количество элементов массива, значения которых лежат в отрезке [10,99].

*Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123*

[5, 18, 123, 6, 2] -> 1

[1, 2, 3, 6, 2]-> 0

[10, 11, 12, 13, 14]-> 5

*/
Console.Clear();
Console.WriteLine("Вот массив из 123 элементов:");
int[] startArray = GetArray(123, 0, 1000);
Console.WriteLine(String.Join(", ", startArray));
Console.WriteLine($"количество элементов от 10 до 99 = {GetCountEl(startArray)}");
int[] GetArray(int a, int min, int max) 
{
    int[] result = new int[a];
    for (int i = 0; i < a; i++) 
    { 
        result[i] = new Random().Next(min, max+1);
    }
    return result;
}

int GetCountEl(int[] array)
{
    int count = 0;
    foreach(int el in array) {
        //if (el > left && el < right)
        if (el > 10 && el < 99)
        count ++;
    }
    return count;
    
}
