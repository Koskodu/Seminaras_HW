/*Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет. 
Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).

645 -> 5
78 -> третьей цифры нет
32679 -> 6
*/

Console.Write("Введите число: ");
int userNumber = Convert.ToInt32(Console.ReadLine());

if (userNumber > 99)
{
    int res = ThirdDigit(userNumber);
    Console.WriteLine($"Третья цифра числа {userNumber} = {res} ");
}

else
{
    Console.WriteLine("Третьей цифры нет!!");
}


int ThirdDigit(int number)

{
    while (number > 999)
    {
        number = number / 10;
    }

    int result = number % 10;
    return result;
}

