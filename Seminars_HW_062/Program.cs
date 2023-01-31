/*Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07*/


void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("[ ");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],2} | ");
            else Console.Write($"{matrix[i, j],2} ");
        }
        Console.WriteLine("]");
    }
}


int[,] FillSpiral(int rows, int columns)
{    
    int[,] sqMatrix = new int[rows, columns];

    int temp = 1;
    int i = 0;
    int j = 0;

    while (temp <= sqMatrix.GetLength(0) * sqMatrix.GetLength(1))
    {
        sqMatrix[i, j] = temp;
        temp++;
        if (i <= j + 1 && i + j < sqMatrix.GetLength(1) - 1)
            j++;
        else if (i < j && i + j >= sqMatrix.GetLength(0) - 1)
            i++;
        else if (i >= j && i + j > sqMatrix.GetLength(1) - 1)
            j--;
        else
            i--;
    }
    return sqMatrix;
}


int[,] arr = FillSpiral(4, 4);
PrintMatrix(arr);


