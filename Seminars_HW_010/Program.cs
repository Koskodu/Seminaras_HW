/*
 Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа. 
 Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).

456 -> 5
782 -> 8
918 -> 1
*/


Console.Write("Введите трехзначное число: ");
int userNumber = Convert.ToInt32(Console.ReadLine());

if (userNumber < 100 || userNumber > 1000)
{
    Console.WriteLine("Число не трехзначное!!");
}

else
{
    int res = SecondDigit(userNumber);
    Console.WriteLine($"Вторая цифра числа {userNumber} = {res} ");
}


int SecondDigit(int number)

{
    int result = number / 10 % 10;
    return result;
}
