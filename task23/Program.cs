/* Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125 */

Console.Clear();
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
    b = i * i * i;
    Console.Write($"{b} ");
    i++;}
