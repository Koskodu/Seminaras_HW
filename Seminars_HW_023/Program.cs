/*Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.*/


void Numb(int n1)
{
    int counter = 1;
    while (counter <= n1)
    {
        Console.WriteLine($"{counter, 5} {Math.Pow(counter, 3), 5}");
        counter++;
    }
}

Console.WriteLine("Введите число:");
int number = Convert.ToInt32(Console.ReadLine());

while (number < 1)
{
    Console.WriteLine("Введите положительное, целое число");
    number = Convert.ToInt32(Console.ReadLine());
}

Numb(number);