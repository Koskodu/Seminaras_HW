/*Напишите цикл, который принимает на вход два числа (A и B)
и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16*/


double Exponent(double numA, double numB)
{
    double result = 1;
    numB = Math.Abs(numB);

    for (double i = 1; i <= numB; i++)
    {
        result = result * numA;
    }

    return result;
}

//again:
Console.Write("Какое число возводим в степень?: ");
double x = Convert.ToDouble(Console.ReadLine());
Console.Write($"В какую степень возвести число {x}: ");
double y = Convert.ToDouble(Console.ReadLine());

double answer = Exponent(x, y);

if (x > 0 && y < 0)
    Console.Write($"Получается = (1/{answer})");

if (x < 0 && y < 0)
    Console.Write($"Получается = -(1/{answer * -1})");

if ((x > 0 && y > 0)|(x < 0 && y > 0))
    //if (y <= 0 || y % 1 != 0)
    //{
    //    Console.WriteLine("Нужно ввести натуральное число для степени");
    //    goto again;
    //}
    //else
    //{
    Console.Write($"Получается = {answer}");
//}

Console.Write($"Получается = {answer}");