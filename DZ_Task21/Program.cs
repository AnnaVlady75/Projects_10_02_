// Задача 21 Напишите программу, которая принимает 
// на вход координаты двух точек и находит 
// расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.WriteLine("Введите координаты x точки A: ");
int numXA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты y точки A: ");
int numYA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты z точки A: ");
int numZA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты x точки B: ");
int numXB = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты y точки B: ");
int numYB = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты z точки B: ");
int numZB = Convert.ToInt32(Console.ReadLine());

double result = Distance(numXA, numYA, numZA, numXB, numYB, numZB);
Console.WriteLine(Math.Round(result, 2, MidpointRounding.ToZero));

double Distance(int xa, int ya, int za, int xb, int yb, int zb)
{
    double sumSquare = Math.Pow(xb - xa, 2) + Math.Pow(yb - ya, 2) +Math.Pow(zb - za, 2);
    double res = Math.Sqrt(sumSquare);
    return res;
}