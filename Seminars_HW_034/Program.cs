/*Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2*/


int[] CreatArray(int arraySize, int arrayMinValue, int arrayMaxValue)//Метод генерации массива со случайными элементами
{
    int[] resArray = new int[arraySize];
    Random rnd = new Random();
    for (int i = 0; i < resArray.Length; i++)
    {
        resArray[i] = rnd.Next(arrayMinValue, arrayMaxValue + 1);
    }
    return resArray;
}


string ArrayToString(int[] array)//Метод преобразования массива в строку
{
    string result = "[";
    for (int i = 0; i < array.Length; i++)
    {
        result = result + $" {array[i]}";
    }
    return result + " ]";
}


int IfEvenCounter(int[] array)//проверка на четность
{
    int result = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0) result++;
    }
    return result;
}


int arraySize = 10, arrayMinValue = 100, arrayMaxValue = 999; 

int[] newArray = CreatArray(arraySize, arrayMinValue, arrayMaxValue); //генерируем массив с указаными параметры
string strArray = ArrayToString(newArray);// переводим строку в массив для дальнейшего вывода на экран

int count = IfEvenCounter(newArray);
Console.Write($"Количество четных чисел в массиве {strArray} >>> {count}");