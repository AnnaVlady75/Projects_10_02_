// Задача 30: Напишите программу, которая
// выводит массив из 8 элементов, заполненный
// нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]

int[] array = new int[8];
FillArray(array);
PrintArray(array);

void FillArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(0, 2);
    }
}


void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i] + "," );
    }
}


// Console.WriteLine("Сколько эллементов в массиве");
// int num = Convert.ToInt32(Console.ReadLine());
// int[] arr = NewRandomArray(num, 0, 10);
// Console.WriteLine($"Полученый массив из {num} эллементов");
// PrintArray(arr);

// //Методы
// int[] NewRandomArray(int num, int min, int max)
// {
//    Random rand = new Random();
//     int[] arr = new int[num];
//     for (int i = 0; i < num; i++)
//     {
//         arr[i] = rand.Next(min, max+1);
//     }
//     return arr;
// }
// void PrintArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write($"{array[i]} ");
//     }
// }