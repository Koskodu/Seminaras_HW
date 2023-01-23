/*Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
и возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
1, 7 -> такого элемента в массиве нет*/

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


Console.Write("На какой позиции находится элемент? пример ввода: 'ряд,столбец' : ");
//string str = Convert.ToString(Console.ReadLine());
//int[] userRowCol = str.Split();

int[] userRowCol = Array.ConvertAll((Console.ReadLine()).Split(','), int.Parse);//массив где ряд, столб от пользователя


if (userRowCol[0] > 4 || userRowCol[1] > 4)
{
    Console.WriteLine("такого элемента нет.");
}
else
{
    int[,] randomMatrix = CreateMatrixRndInt(4, 4, -10, 10);
    int result = randomMatrix[userRowCol[0] - 1, userRowCol[1] - 1];
    PrintMatrix(randomMatrix);
    Console.WriteLine($"значение элемента на позиции строка({userRowCol[0]}), столбец({userRowCol[1]}) = {result}");
}