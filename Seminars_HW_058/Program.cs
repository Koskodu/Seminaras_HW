/*Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18*/


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


int[,] MatrixMultiplication(int[,] matrixA, int[,] matrixB)
{
    
    if (matrixA.GetLength(1) != matrixB.GetLength(0))
    {
        throw new Exception("Количество столбцов первой матрицы должно быть равно количеству строк второй матрицы.");
    }

    int[,] matrixC = new int[matrixA.GetLength(0), matrixB.GetLength(1)];

    for (int i = 0; i < matrixA.GetLength(0); i++)
    {
        for (int j = 0; j < matrixB.GetLength(1); j++)
        {
            matrixC[i, j] = 0;

            for (int k = 0; k < matrixA.GetLength(1); k++)
            {
                matrixC[i, j] += matrixA[i, k] * matrixB[k, j];
            }
        }
    }

    return matrixC;
}


int[,] matA = CreateMatrixRndInt(2, 2, 1, 4);
int[,] matB = CreateMatrixRndInt(2, 2, 1, 4);

Console.WriteLine("Матрица A:");
PrintMatrix(matA);

Console.WriteLine("Матрица B:");
PrintMatrix(matB);

int[,] resMatrix = MatrixMultiplication(matA, matB);
Console.WriteLine("Произведение матриц:");
PrintMatrix(resMatrix);