/*Задача 21
Напишите программу, которая принимает на вход координаты двух точек и 
находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53*/

int InsertPositon(string text)
{
    Console.WriteLine(text);
    int pos = Convert.ToInt32(Console.ReadLine());
    return pos;
}

int x1 = InsertPositon("Введите координату Х первой точки:");
int y1 = InsertPositon("Введите координату Y первой точки:");
int z1 = InsertPositon("Введите координату Z первой точки:");

int x2 = InsertPositon("Введите координату Х второй точки:");
int y2 = InsertPositon("Введите координату Y второй точки:");
int z2 = InsertPositon("Введите координату Z первой точки:");

double LenghtLine(int xpos1, int xpos2, int ypos1, int ypos2, int zpos1, int zpos2)
{
    int temp = (xpos1 - xpos2) * (xpos1 - xpos2) + (ypos1 - ypos2) * (ypos1 - ypos2) + (zpos1 - zpos2) * (zpos1 - zpos2);
    return Math.Sqrt(temp);
}

double res = LenghtLine(x1, x2, y1, y2, z1, z2);
double resRound = Math.Round(res, 2, MidpointRounding.ToZero);

Console.WriteLine($"Растояние между точками равно :{resRound}");
