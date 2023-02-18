// Задача 20: Напишите программу, которая
// принимает на вход координаты двух точек и
// находит расстояние между ними в 2D
// пространстве.
// A (3,6); B (2,1) -> 5,09
// A (7,-5); B (1,-1) -> 7,21

Console.WriteLine("Введите координаты x точки 1: ");
int numX1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты y точки 1: ");
int numY1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты x точки 2: ");
int numX2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты y точки 2: ");
int numY2 = Convert.ToInt32(Console.ReadLine());

double result = Distance(numX1, numY1, numX2, numY2);
Console.WriteLine(Math.Round(result, 2, MidpointRounding.ToZero));

double Distance(int x1, int y1, int x2, int y2)
{
    double sumSquare = Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2);
    double res  = Math.Sqrt(sumSquare);
    return res;

}
// double d = 5.09998774;
// double dRound = Math.Round(d, 2, MidpointRounding.ToZero); //округления
// Console.WriteLine(dRound);