/* программа принимает число а, и выводит сумму от 1 до а
а = 5
sum = 1+2+3+4+5;*/

int Summy(int j){
    int sum = 0;
    for ( int i = 1; i <= j; i++)
        sum = sum + i;
    return sum;
}

Console.Clear();
Console.WriteLine("Введите любое число");
int j = int.Parse(Console.ReadLine());
// Summy(n);
Console.WriteLine($"Сумма от 1 до {j} равна {Summy(j)}");


