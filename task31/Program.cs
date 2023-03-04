//Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9].
//Найдите сумму отрицательных и положительных элементов массива.

Console.Clear();
Console.WriteLine("Вот массив из 12 элементов:");
int[] r(int a, int min, int max) 
{
    int[] result = new int[a];
    for (int i = 0; i < a; i++) 
    { 
        result[i] = new Random().Next(min, max);
    }
    return result;
}
/*int [] b = r(a);
Console.WriteLine(".");
Console.WriteLine("Теперь попытаемся вывести сумму положительных и отрицательнхы элементов");*/

int[] SumPosNeg(int[] array)
{
    int[] result = new int[2];
    foreach (int el in array)
    {
        result[0] += el > 0 ? el:0;
        result[1] += el < 0 ? el:0; 
    }
    return result;
}

int[] array = r(12, -9, 10);
Console.WriteLine(String.Join(", ", array));
Console.WriteLine($"Сумма положительных элементов равна {SumPosNeg(array)[0]}, а сумма отрицательных элементов равна {SumPosNeg(array)[1]}");



