/*Задача 64: Задайте значение N. 
Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. 
Выполнить с помощью рекурсии.
N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"*/

System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");

Console.Write("Введите натуральное число: ");
double number = Convert.ToDouble(Console.ReadLine());

if (number <= 0 || number % 1 != 0)
    Console.WriteLine("Число должно быть целым и больше 0");
else
    NaturNumbers(number);

void NaturNumbers(double num)
{
    if (num == 0) return;
    Console.Write($"{num} ");
    NaturNumbers(num - 1);
}