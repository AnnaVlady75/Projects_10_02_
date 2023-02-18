// Задача 22: Напишите программу, которая
// принимает на вход число (N) и выдаёт таблицу
// квадратов чисел от 1 до N.
// 5 -> 1, 4, 9, 16, 25.
// 2 -> 1,4
int number  = Prompt("Ввежите натуральное число: ");


if (number > 0) TableSqr(number);
else Console.WriteLine("Dведено НЕнатуральное число ");

void TableSqr(int n)
{
    Console.WriteLine("Число        Квадрат числа ");
    for (int i = 1; i <= n; i++)
    {
        Console.WriteLine($"{i, 5} -> {i*i, 5}");
    }
}

int Prompt(string message)
{
        Console.WriteLine(message);
        int num = Convert.ToInt32(Console.ReadLine());
        return num;
}
