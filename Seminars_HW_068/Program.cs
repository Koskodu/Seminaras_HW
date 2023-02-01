/*Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29*/


Console.Write("Введите первое число : ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число : ");
int n = Convert.ToInt32(Console.ReadLine());

int AkFunction(int val1, int val2)
{
    if (val1 == 0)
        return val2 + 1;
    else
    if ((val1 != 0) && (val2 == 0))
        return AkFunction(val1 - 1, 1);
    else
        return AkFunction(val1 - 1, AkFunction(val1, val2 - 1));
}

int res = AkFunction(m, n);
Console.WriteLine($"{res}");