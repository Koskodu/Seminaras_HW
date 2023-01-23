/*Задача 43:
Напишите программу, которая найдёт точку пересечения двух прямых,
заданных уравнениями
y = k1 * x + b1,
y = k2 * x + b2;
значения b1, k1, b2 и k2 задаются пользователем.

b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

k1 * x + b1 = k2 * x + b2
k1 * x - k2 * x = b2 - b1
x (k1 - k2) = b2 - b1
x = (b1 - b2) / (k2 - k1)

если снизу 0 то //
если 0/0 то совпадают

для вывода ответа
out
кортеж*/

System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US"); //что бы точка была

double[] CreateUserArray(string[] args) //создаем пользовательский массив с параметрами прямых
{
    double[] array = new double[4];

    for (int i = 0; i < array.Length; i++)
    {
        if (i == 0)
        {
            Console.Write($"Введите значение b1 : ");
            array[i] = Convert.ToDouble(Console.ReadLine());
        }
        if (i == 1)
        {
            Console.Write($"Введите значение k1 : ");
            array[i] = Convert.ToDouble(Console.ReadLine());
        }
        if (i == 2)
        {
            Console.Write($"Введите значение b2 : ");
            array[i] = Convert.ToDouble(Console.ReadLine());
        }
        if (i == 3)
        {
            Console.Write($"Введите значение k2 : ");
            array[i] = Convert.ToDouble(Console.ReadLine());
        }
    }
    return array;
}


bool IfParalel(double[] arrr)   //проверка на параллельность

{
    if ((arrr[1] * arrr[2] - arrr[3] * arrr[0] == 0) || (arrr[1] == arrr[3])) return true;
    else return false;
}


(double, double) IfCross(double[] arrr) //поиск точки пересечения

{
    double b1 = arrr[0], k1 = arrr[1], b2 = arrr[2], k2 = arrr[3];
    double x, y;

    x = (b1 - b2) / (k2 - k1);
    y = k1 * x + b1;
    //(double, double) result = (x, y);

    return (x, y);
}

double[] arr = CreateUserArray(args);

if (IfParalel(arr) == true)
{
    Console.WriteLine("Прямые параллельны");
}
else
{
    (double, double) resTuple = IfCross(arr);
    Console.WriteLine($"Прямые пересекутся в точке [ {Math.Round(resTuple.Item1, 3)}, {Math.Round(resTuple.Item2, 3)} ]");
}
