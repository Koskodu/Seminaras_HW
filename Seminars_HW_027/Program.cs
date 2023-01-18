/*Задача 27: Напишите программу, которая принимает на вход число
и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12*/


int SumNumbers(int userN)
{
    userN = Math.Abs(userN);
    int numLength = Convert.ToString(userN).Length;
    int result = 0;

    for (int i = 0; i < numLength; i++)
    {
        result = result + userN % 10;
        userN = userN / 10;
    }
    return result;
}

Console.Write("Введите число для которого посчитаем сумму его цифр: ");
int numberN = Convert.ToInt32(Console.ReadLine());

int sumNumber = SumNumbers(numberN);
Console.Write($"Сумма цифр = {sumNumber}");

