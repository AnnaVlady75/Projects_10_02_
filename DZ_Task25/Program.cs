// Задача 25: Напишите цикл, который принимает 
// на вход два числа (A и B) и возводит 
// число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.WriteLine("Введите число А: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число B: ");
int numberB = Convert.ToInt32(Console.ReadLine());

if (numberB > 0)
    Console.WriteLine($"{numberA} в степени {numberB} -> {NumberPow(numberA, numberB)}");
else Console.WriteLine($"Ошибка ввода: число {numberB} НЕ натуральное");


int NumberPow(int numA, int numB)
{
    int count = 1;
    for (int i = 0; i < numB; i++)
    {
        checked
        {
            count *= numA;
        }
    }
    return count;
}



