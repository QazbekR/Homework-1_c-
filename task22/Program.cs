// Напишите программу, которая принимает на вход число (N)
//  и выдаёт таблицу квадратов чисел от 1 до N.

// 5 -> 1, 4, 9, 16, 25.

// 2 -> 1,4

Console.WriteLine("Введите число N");
int n = int.Parse(Console.ReadLine());
/*int[] mas = new int[n];
for (int i = 1; i <=n; i++)
    mas[i-1] = i * i;
for (int i = 0; i < n; i++)
    Console.Write($"{mas[i]} ");*/
int i = 1;
int b = 0;
while (i <= n) {
    b = i * i;
    Console.Write($"{b} ");
    i++;}
