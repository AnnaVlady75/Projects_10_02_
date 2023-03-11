// Задача 66: Задайте значения M и N. 
// Напишите программу, которая найдёт 
// сумму натуральных элементов в промежутке 
// от M до N. Выполнить с помощью рекурсии.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.WriteLine("Введите число M: ");
int number1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите натуральное число N: ");
int number2 = int.Parse(Console.ReadLine());

Console.WriteLine(SumElemsRec(number1, number2));


int SumElemsRec(int num1, int num2)
{
    if (num1 == num2) return num1;
    if (num1 > num2)
        return num2 + SumElemsRec(num2 + 1, num1);
    else
        return num1 + SumElemsRec(num1 + 1, num2);
}
