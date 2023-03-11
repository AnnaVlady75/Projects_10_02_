// Задача 41: Пользователь вводит 
// с клавиатуры M чисел. Посчитайте, 
// сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

int CreateUsersArray(string message)
{
     Console.WriteLine(message);
    int m = int.Parse(Console.ReadLine()!);
    return m;
}

int[] FillUsersArray(int quantity)
{
    int[] array = new int[quantity];
    for (int i = 0; i < quantity; i++)
    {
        Console.WriteLine("Введите числа: ");
        array [i] = int.Parse(Console.ReadLine()!);
    }
    return array;
}

int CountPositiveNumbers(int[] sumcount)
{
    int count = 0;
    for (int i = 0; i < sumcount.Length; i++)
    {
        if (sumcount[i] > 0) { count++; }
    }
    return count;
}

int quantity = CreateUsersArray("Введите M(количество) чисел: ");
int[] array = FillUsersArray(quantity);
int сountPositiveNumbers = CountPositiveNumbers(array);
Console.WriteLine($"Количество чисел больше 0 -> {сountPositiveNumbers}.");



