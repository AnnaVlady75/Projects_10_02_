// Задача 23 Напишите программу, которая принимает 
// на вход число (N) и выдаёт 
// таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

int number  = Prompt("Введите натуральное число: ");


if (number > 0) TableСubes(number);
else Console.WriteLine("Введено НЕнатуральное число ");

void TableСubes(int num)
{
    Console.WriteLine("Число        Куб числа ");
    for (int i = 1; i <= num; i++)
    {
        Console.WriteLine($"{i, 5} -> {Math.Pow(i, 3), 5}");
    }
}

int Prompt(string message)
{
        Console.WriteLine(message);
        int num = Convert.ToInt32(Console.ReadLine());
        return num;
}
