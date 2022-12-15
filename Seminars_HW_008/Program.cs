// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

Console.Write("Введите положительное число : ");
int number = Convert.ToInt32(Console.ReadLine());
int Count = 1;

Console.Write($"Четные числа от 1 до {number} : ");

while(Count<=number)
{
    if (Count % 2 == 0)
    {
    Console.Write($"-{Count}- ");
    }
   
    Count++;
}