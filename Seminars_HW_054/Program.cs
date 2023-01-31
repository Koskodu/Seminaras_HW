/*Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2*/



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


void PrintArrayDouble(int[] mainArray)
{
    Console.Write("[ ");
    for (int i = 0; i < mainArray.Length; i++)
    {
        if (i < mainArray.Length - 1) Console.Write($"{mainArray[i],5} | ");
        else Console.Write($"{mainArray[i],5}  ");
    }
    Console.WriteLine(" ]");
}


void BubbleSort(int[] inArray)
{
    for (int i = 0; i < inArray.Length; i++)
    {
        for (int j = 0; j < inArray.Length - 1 - i; j++)
        {
            if (inArray[j] < inArray[j + 1])
            {
                int temp = inArray[j];
                inArray[j] = inArray[j + 1];
                inArray[j + 1] = temp;
            }
        }
    }
}


void SortedMatrix(int[,] matrix1)
{
    int[] row = new int[matrix1.GetLength(1)];
    int k = 0;
    for (int i = 0; i < matrix1.GetLength(0); i++)
    {
        for (int j = 0; j < matrix1.GetLength(1); j++)
        {
            row[k] = matrix1[i, j];
            k++;
        }
        BubbleSort(row);
        PrintArrayDouble(row);
        k = 0;
    }
}



int[,] mainMatrix = CreateMatrixRndInt(4, 6, 1, 35);
PrintMatrix(mainMatrix);
Console.WriteLine('\n');
SortedMatrix(mainMatrix);

