// **Задача 42:**Напишите программу,
// которая будет преобразовывать десятичное число в двоичное.

// 45 -> 101101

// 3 -> 11

// 2 -> 10

Console.Clear();
int number = int.Parse(Console.ReadLine());

string res = DecToNum(number, 16);

Console.WriteLine($"{number} - > {res}");

//Универсальный метод для любой системы исчисления.
string DecToNum(int decNumber, int otherSystem)
{
    string res = "";
    string nums = "0123456789ABCDEF";
    while (decNumber > 0)
    {
        int ost = decNumber / otherSystem;
        res = nums[decNumber / otherSystem * ost] + res; // по идее можно было б через процент, сразу остаток вывести
        decNumber /= otherSystem;
    }
    return res;
}
