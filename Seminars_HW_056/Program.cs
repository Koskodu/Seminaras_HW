/*Задача 56: Задайте прямоугольный двумерный массив. 
Напишите программу, которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка*/



int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("[ ");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],5} | ");
            else Console.Write($"{matrix[i, j],5}  ");
        }
        Console.WriteLine(" ]");
    }
}

int[] GetSumRowFromMatrix(int[,] matrix)
{
    int[] rowSum = new int[matrix.GetLength(0)];
    int sum = 0;
    int ind = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            sum = sum + matrix[i, j];
        }
        rowSum[ind] = sum;
        ind++;
        sum = 0;
    }
    return rowSum;
}

(int, int) FindRow(int[] array)
{
    int index = 0;
    int min = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] < min)
        {
            min = array[i];
            index = i;
        }
    }

    return (index = index + 1, min);
}

void PrintArrayDouble(int[] mainArray)
{
    Console.Write("[ ");
    for (int i = 0; i < mainArray.Length; i++)
    {
        if (i < mainArray.Length - 1) Console.Write(mainArray[i] + " | ");
        else Console.Write(mainArray[i]);
    }
    Console.WriteLine(" ]");
}


int[,] mainMatrix = CreateMatrixRndInt(4, 3, 1, 9);
PrintMatrix(mainMatrix);
Console.WriteLine('\n');

int[] rowSumArray = GetSumRowFromMatrix(mainMatrix);
Console.WriteLine("Сумма в каждой строке:");
PrintArrayDouble(rowSumArray);
Console.WriteLine('\n');

(int resultRow, int minVal) = FindRow(rowSumArray);
Console.WriteLine($"Минимальная сумма элеиентов {minVal} в строке {resultRow}");