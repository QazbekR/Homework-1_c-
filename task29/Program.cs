/*Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

6, 1, 33 -> [6, 1, 33]*/

Console.Clear();
int a = new Random().Next(8, 9);
Console.Write("[");
int[] r(int a) 
{
    int[] array = new int[a];
    for (int i = 0; i < a; i++) 
    { 
        array [i] = new Random().Next(100);
        Console.Write($"{array[i]}, ");
    }
    return array;
}
int [] b = r(a);
Console.Write("]");
