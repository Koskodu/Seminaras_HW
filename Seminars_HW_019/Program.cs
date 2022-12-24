/*Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).
14212 -> нет
12821 -> да
23432 -> да*/

Console.Write("Введите число для проверки на полиндромность: ");
int number = Convert.ToInt32(Console.ReadLine());

bool IsPalindrome(int x)
{
    x = Math.Abs(x);

    if (x % 10 == 0 && x != 0) 
    return false;

    int revNumber = 0;

    while (x > revNumber)
    {
        revNumber = revNumber * 10 + x % 10;
        x = x / 10;
    }
    return x == revNumber || x == revNumber / 10;
}

Console.WriteLine(IsPalindrome(number));