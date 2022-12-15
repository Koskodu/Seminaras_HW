/*Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.*/

Console.Write("Введите первое число для сравнения : ");
int First = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите ыторое число для сравнения : ");
int Second = Convert.ToInt32(Console.ReadLine());

if (First == Second) 
{
    Console.WriteLine("Числа равны");
}
else

    if (First > Second)
    {
        Console.WriteLine("Первое число больше");
    }
    else
        Console.WriteLine("Второе число больше");

