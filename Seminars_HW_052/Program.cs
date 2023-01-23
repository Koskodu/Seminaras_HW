﻿/*Задача 52. Задайте двумерный массив из целых чисел. 
Найдите среднее арифметическое элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.*/


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
        if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j], 5} | ");
        else Console.Write($"{matrix[i, j], 5}  ");
    }
    Console.WriteLine(" ]");
    }
}


void MidSum(int[,] matrix)
{
    double sum = 0;
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            sum = sum + matrix[i, j];          
        }
        Console.Write($"{(sum / matrix.GetLength(0)), 6}   ");
        sum = 0;
    }
}

int[,] randomMatrix = CreateMatrixRndInt(4, 4, -5, 5);
PrintMatrix(randomMatrix);
Console.WriteLine("Среднее арифмитическое в столбце =");
MidSum(randomMatrix);