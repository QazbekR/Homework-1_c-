//30 Напишите программу, которая выводит массив из 8 элементов,
//заполненный нулями и единицами в случайном порядке.

//[1,0,1,1,0,1,0,0]
// a = new Random().Next()
// Random r = new Random();
// int a = new Random().Next(2, 10)
// int a = r.Next(2, 10);
// int a = r.Next(2);


/*Console.Clear();
int num1 = new Random().Next(10, 100);
int num2 = new Random().Next(1, 10);
int max = num1 % num2;
if  (max > 0) {Console.WriteLine($"{num1} не кратно {num2}, остаток {max}");}
else {Console.WriteLine($"{num1} кратно {num2}");} */

Console.Clear();
int a = new Random().Next(8,9); // это количество элементов массива

int[] r(int a) 
{
    int[] array = new int[a];
    for (int i = 0; i < a; i++) 
    { 
        array [i] = new Random().Next(0,2);
        Console.Write(array[i]   );
    }
    return array;
}
int [] b = r(a);



