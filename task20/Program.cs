// 20 Напишите программу, 
// которая принимает на вход координаты двух точек и находит 
// расстояние между ними в 2D пространстве.

// A (3,6); B(2, 1)-> 5,09
// A(7, -5); B(1, -1)-> 7,21
//sqrt((3 - 2)^2 + (6 - 1)^2) = 5.09
//double s = Math.Sqrt(...);

Console.Clear();
Console.WriteLine("Введите координату Х первой точки");
int x1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите координату Y первой точки");
int y1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите координату Х второй точки");
int x2 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите координату Y второй точки");
int y2 = int.Parse(Console.ReadLine());
double distance = Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2)); // math pow это степень, то есть х1 - х2 и степень 2
Console.WriteLine($"Точка А ({x1}; {y1}). Точка B ({x2}; {y2})");
Console.WriteLine($"Расстояние между точками А и В - {distance}");

