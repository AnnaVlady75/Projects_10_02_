// Задача 15: Напишите программу, которая 
// принимает на вход цифру, обозначающую день недели, 
// и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("Введите цифру: ");
int digit = Convert.ToInt32(Console.ReadLine());

if (Weekend(digit))
    Console.WriteLine("Это выходной ");
else Console.WriteLine("Это НЕ выходной! ");

if (digit > 7)
    
    Console.WriteLine("Это НЕ день недели! ");
    return;

bool Weekend(int weekdig)
{
    return weekdig > 5;
}