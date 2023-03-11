/**Задача 39:** Напишите программу, которая перевернёт одномерный массив (последний элемент будет на первом месте, а первый - на последнем и т.д.)

[1 2 3 4 5] -> [5 4 3 2 1]

[6 7 3 6] -> [6 3 7 6]*/

Console.Clear();
Console.WriteLine("Вот массив из 10 элементов:");
int[] array = GetArray(10, 1, 50);
Console.WriteLine(String.Join(", ", array));

int[] reversArray = ReversArray2(array);
Console.WriteLine(String.Join(", ", reversArray));

ReversArray1(array);
Console.WriteLine(String.Join(", ", array));

int[] GetArray(int a, int min, int max) 
{
    int[] result = new int[a];
    for (int i = 0; i < a; i++) 
    { 
        result[i] = new Random().Next(min, max);
    }
    return result;
}

void ReversArray1(int[] inArray) 
{
    for (int i = 0; i < inArray.Length / 2; i++)
    {
        int k = inArray[i];
        inArray[i] = inArray[inArray.Length - i - 1];
        inArray[inArray.Length - i -1] = k;
    }
}

int[] ReversArray2(int[] inArray)
{
    int[] result = new int[inArray.Length];
    for (int i = 0; i < inArray.Length; i++)
    {
        result[i] = inArray[inArray.Length - 1 - i];
    }
    return result;
}