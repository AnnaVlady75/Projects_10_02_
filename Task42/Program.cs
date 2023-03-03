// Задача 42: Напишите программу, 
// которая будет преобразовывать
// десятичное число в двоичное.
// 45 -> 101101
// 3 -> 11
// 2 -> 10


string TransformationNumber(int num)
{
    string newNum = string.Empty;
    while (num != 0)
    {
        newNum = num % 2 + newNum;
        num = num / 2;
    }
    return newNum;
}

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
string transformationNumber = TransformationNumber(number);
Console.WriteLine(transformationNumber);


//Метод через int
// Console.WriteLine("Введите число");
// int number = Convert.ToInt32(Console.ReadLine());

// int DecToBin(int num)
// {
//     int count = 1;
//     int result = 0;
//     while (num > 0)
//     {
//         result = result + num % 2 * count;
//         num = num / 2;
//         count *= 10;
//     }
//     return result;
// }
// int decToBin = DecToBin(number);
// Console.WriteLine($"{number} -> {decToBin}");