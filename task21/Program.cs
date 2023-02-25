/* Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

A (3,6,8); B (2,1,-7), -> 15.84

A (7,-5, 0); B (1,-1,9) -> 11.53 */

Console.Clear();
Console.WriteLine("Введите координату Х первой точки");
int x1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите координату Y первой точки");
int y1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите координату Z первой точки");
int z1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите координату Х второй точки");
int x2 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите координату Y второй точки");
int y2 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите координату Z второй точки");
int z2 = int.Parse(Console.ReadLine());
double distance = Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2) + Math.Pow(z1 - z2, 2)); // math pow это степень, то есть х1 - х2 и степень 2
Console.WriteLine($"Точка А ({x1}; {y1}; {z1}). Точка B ({x2}; {y2}; {z2})");
Console.WriteLine($"Расстояние между точками А и В - {distance}");