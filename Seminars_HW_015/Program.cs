/*Напишите программу, которая принимает на вход цифру, 
обозначающую день недели, и проверяет, является ли этот день выходным.

6 -> да
7 -> да
1 -> нет
*/

Console.Write("Введи цифру, обозначающую день недели: ");
int dayNumber = Convert.ToInt32(Console.ReadLine());

void IsWeekend(int dayNumber)
{
    if (dayNumber == 6 || dayNumber == 7)
    {
        Console.WriteLine($"{dayNumber}й день на неделе выходной! Ура!!!");
    }
    else if (dayNumber < 1 || dayNumber > 7)
    {
        Console.WriteLine("В неделе 7 дней так то");
    }
    else Console.WriteLine($"{dayNumber}й день на неделе не выходной =(");
}

IsWeekend(dayNumber);