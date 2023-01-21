/*Задача 41: Пользователь вводит с клавиатуры M чисел.
Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3*/


int[] CreateUserArray(string[] args) //создаем пользовательский массив
{
    mistake:
    Console.Write("Введите количество элементов массива: ");

    int elementsCount = int.Parse(Console.ReadLine()); // принимаем размер массива от пользователя

    if (elementsCount <= 0) //проверяем правильность ввода размера
    {
        Console.WriteLine($"Размерность массива должна быть положительная! Повторите ввод.");
        goto mistake;
    }

    int[] array = new int[elementsCount]; //создаем массив заданной величины
    for (int i = 0; i < array.Length; i++) 
    {
        Console.Write($"Введите элемент массива с индексом {i} : ");
        array[i] = int.Parse(Console.ReadLine());
    }

    return array;
}

void PrintArray(int[] mainArray)
{
    Console.Write("[ ");
    for (int i = 0; i < mainArray.Length; i++)
    {
        if (i < mainArray.Length - 1)
            Console.Write(mainArray[i] + " | ");
        else
            Console.Write(mainArray[i]);
    }
    Console.WriteLine(" ]");
}

int IfPositive(int[] arr) //проверяем сколько чисел больше 0
{
    int result = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0)
            result = result + 1;
    }
    return result;
}

int[] userArray = CreateUserArray(args);
int positiveCount = IfPositive(userArray);

PrintArray(userArray);
Console.WriteLine($"Количество положительных элементов в массиве: {positiveCount}");
