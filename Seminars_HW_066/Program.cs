/*Задача 66: Задайте значения M и N. 
Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N. 
Выполнить с помощью рекурсии.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30*/

Console.Write("Введите первое число : ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число : ");
int n = Convert.ToInt32(Console.ReadLine());

int SumNatural(int digit1, int digit2)
{
    if (digit1 < digit2)
    {
    return digit1 == digit2? digit2 : digit1 + SumNatural(digit1 + 1, digit2);
    }
    else
    {
    return digit1 == digit2? digit2 : digit2 + SumNatural(digit1, digit2 + 1);
    }
}

int natSum = SumNatural(m, n);
Console.WriteLine($"Сумму натуральных элементов в промежутке от {m} до {n} = {natSum}");