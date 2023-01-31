/**Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
Например, задан массив размером 2 x 2 x 2.
Результат:
66(0,0,0) 27(0,0,1) 25(0,1,0) 90(0,1,1)
34(1,0,0) 26(1,0,1) 41(1,1,0) 55(1,1,1)*/



int[,,] Create3DMatrix(int[] sizes, int min, int max)
{
    int[,,] matrix3D = new int[sizes[0], sizes[1], sizes[2]];
    
    for (int i = 0; i < matrix3D.GetLength(0); i++)
    {
        for (int j = 0; j < matrix3D.GetLength(1); j++)
        {
            int k = 0;
            while (k < matrix3D.GetLength(2))
            {
                int element = new Random().Next(min, max + 1);

                if (IfExist(matrix3D, element)) continue;
                matrix3D[i, j, k] = element;
                k++;
            }
        }
    }
    return matrix3D;
}


bool IfExist(int[,,] array, int elem)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                if (array[i, j, k] == elem) return true;
            }
        }
    }
    return false;
}
void PrintArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                Console.Write($"{array[i, j, k],2} ({i},{j},{k})  ");
            }                        
        }
        Console.WriteLine();
    }
}

Console.WriteLine("Введите размеры 3D массива через запятую: ");
string[] nums = Console.ReadLine().Split(",", StringSplitOptions.RemoveEmptyEntries);
int[,,] array = Create3DMatrix(new int[] { int.Parse(nums[0]), int.Parse(nums[1]), int.Parse(nums[2]), }, 10, 999);
PrintArray(array);
