/* **Задача 33:**Задайте массив.Напишите программу,
которая определяет, присутствует ли заданное число в массиве.

4; массив[6, 7, 19, 345, 3]->нет

3; массив[6, 7, 19, 345, 3]->да*/


Console.Clear();
Console.WriteLine("Вот массив из 6 элементов:");
int[] startArray = GetArray(6, -9, 10);
Console.WriteLine(String.Join(", ", startArray));
Console.WriteLine("Введите число которое нужно найти:");
int b = int.Parse(Console.ReadLine());


int[] GetArray(int a, int min, int max) 
{
    int[] result = new int[a];
    for (int i = 0; i < a; i++) 
    { 
        result[i] = new Random().Next(min, max);
    }
    return result;
}

bool prov (int[] array, int el)
{
    foreach (var item in array) 
    {
        if(el == item) return true;  
    };
    return false;
}

if (prov(startArray, b)) {Console.WriteLine("да");}
else {Console.WriteLine("нет");}

