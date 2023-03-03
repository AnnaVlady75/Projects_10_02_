// Задача 40: Напишите программу, 
//которая принимает на вход три
// числа и проверяет, 
//может ли существовать треугольник с сторонами
// такой длины.
// Теорема о неравенстве треугольника: 
//каждая сторона треугольника
// меньше суммы двух других сторон.

bool InequalityTriangle(int a1, int b1, int c1)
{
    return a1 >= b1 + c1
        || b1 >= a1 + c1
        || c1 >= a1 + b1;
}

Console.WriteLine("Введите число 1: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число 2: ");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число 3: ");
int num3 = Convert.ToInt32(Console.ReadLine());

bool inequalityTriangle = InequalityTriangle(num1, num2, num3);
Console.WriteLine(inequalityTriangle ? "Да" : "Нет");




