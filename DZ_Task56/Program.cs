// Задача 56: Задайте прямоугольный двумерный массив.
//  Напишите программу, которая будет находить 
//  строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке 
// и выдаёт номер строки с наименьшей суммой элементов: 1 строка


int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j],4} ");
        }
        Console.WriteLine();
    }
}

int[] SumRowElems(int[,] matrix)
{
    int row = matrix.GetLength(0);
    int[] array = new int[row];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            sum += matrix[i, j];
        }
        array[i] = sum;
    }
    return array;
}
void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i],4}; ");
        else Console.Write($"{array[i],4}.");
    }
}

int MinSumRow(int[] array)
{
    int minRow = array[0];
    int numberMinRow = 0;
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] < minRow)
            numberMinRow = i;
        minRow = array[i];
    }
    return numberMinRow;
}

int[,] array2d = CreateMatrixRndInt(3, 4, 0, 10);
PrintMatrix(array2d);
Console.WriteLine();
int[] sumRowElems = SumRowElems(array2d);
PrintArray(sumRowElems);
Console.WriteLine();
int minSumRow = MinSumRow(sumRowElems);
Console.WriteLine($"Номер строки с наименьшей суммой элементов: {minSumRow +1} ");