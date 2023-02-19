// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

/*645 -> 5

78 -> третьей цифры нет

32679 -> 6*/

Console.Clear();
Console.WriteLine("Введите любое число");
int a = int.Parse(Console.ReadLine());
if (a > 99 && a < 1000) {
    int b = a % 10;
    Console.WriteLine($"{b} ");}
if (a < 100) {Console.WriteLine("Трейтьей цифры нет");}
if (a > 999) {
    while ( a > 999) { a /= 10;}
    int b = a % 10;
    Console.WriteLine($"{b} ");}
