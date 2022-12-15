//Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

Console.Write("Введите первое число  : ");
int First = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число для сравнения : ");
int Second = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите третье число для сравнения : ");
int Third = Convert.ToInt32(Console.ReadLine());
int Max_number = First;

    if (Second > Max_number)
    {
        Max_number = Second;
    }                 
    
    if (Third > Max_number)
    {
         Max_number = Third;
    }
    
Console.Write($"Максимальное число  {Max_number}");
    



