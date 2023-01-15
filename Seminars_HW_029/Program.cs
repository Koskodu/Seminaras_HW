/*Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
1, 2, 5, 7, 19, 6, 1, 33 -> [1, 2, 5, 7, 19, 6, 1, 33]*/


int[] ArrayGen(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(0, 100);
    }
    return array;
}

int[] arr = ArrayGen(5);

Console.Write('[');
for (int i = 0; i < (arr.Length - 1); i++)
{
    Console.Write($"{arr[i]},");    
}
Console.Write($"{arr[^1]}]");