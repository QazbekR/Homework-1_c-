// **Задача 18:**

// Напишите программу, которая по заданному номеру четверти, 
// показывает диапазон возможных координат точек в этой четверти (x и y).

Console.Clear();
Console.WriteLine("ВВедите номер четверти");
int a = int.Parse(Console.ReadLine());
switch (a)
{
    case 1:{Console.WriteLine("Х > 0 and Y > 0");
    break;
    }
    case 2:{Console.WriteLine("Х < 0 and Y > 0");
    break;
    }
    case 3:{Console.WriteLine("Х < 0 and Y < 0");
    break;
    }
    case 4:{Console.WriteLine("Х > 0 and Y < 0");
    break;
    }
    default:{Console.WriteLine("неправильная четверть");
    break;
    }
}
/*if (a == 1) {Console.WriteLine("Х > 0 and Y > 0");}
if (a == 2) {Console.WriteLine("Х < 0 and Y > 0");}
if (a == 3) {Console.WriteLine("Х < 0 and Y < 0");}
if (a == 4) {Console.WriteLine("Х > 0 and Y < 0");}
*/
