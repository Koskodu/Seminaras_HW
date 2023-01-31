/*Задача 38: Задайте массив вещественных чисел. 
Найдите разницу между максимальным и минимальным элементов массива.
[3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2*/



System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US"); //что бы точка была


double[] CreateArrayRndDouble(int arraySize, int arrayMinValue, int arrayMaxValue)//Метод генерации массива со случайными вещественными элементами
{
    double[] mainArray = new double[arraySize];//создание массива вещественных значений
    Random rnd = new Random();
    for (int i = 0; i < mainArray.Length; i++)
    {
        mainArray[i] = rnd.NextDouble() * (arrayMaxValue - arrayMinValue) + arrayMinValue;//получение рандом вещественного числа(по дефолту без множителя дает диапазон чисел от 0.0 до 1.0)
        mainArray[i] = Math.Round(mainArray[i], 1);//округление до 1го знака после запятой
    }
    return mainArray;
}


void PrintArrayDouble(double[] mainArray)
{
    Console.Write("[ ");
    for (int i = 0; i < mainArray.Length; i++)
    {
        if (i < mainArray.Length - 1) Console.Write(mainArray[i] + " | ");
        else Console.Write(mainArray[i]);
    }
    Console.WriteLine(" ]");
}

double FindMaxValue(double[] array) //поиск максимального элемента
{
    double max = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] > max)
            max = array[i];
    }
    return max;
}

double FindMinValue(double[] array) //поиск минимального элемента
{
    double min = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] < min)
            min = array[i];
    }
    return min;

}


double[] array = CreateArrayRndDouble(5, 1, 10); //создание вещественного массива с 5ю элементами от 1 до 10
PrintArrayDouble(array);//вывод массива в консоль

double minVal = FindMinValue(array);
double maxVal = FindMaxValue(array);

double diffMaxMin = Math.Round((maxVal - minVal), 1); //получение и округление разницы макс и мин элементов
Console.WriteLine($"Разница между максимальным ({maxVal}) и минимальным ({minVal}) элементами массива >>> {diffMaxMin}");