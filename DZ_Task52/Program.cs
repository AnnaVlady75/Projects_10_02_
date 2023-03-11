// Задача 52. Задайте двумерный массив из 
// целых чисел. Найдите 
// среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.


double[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    double[,] matrix = new double[rows, columns];
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = Math.Round(rnd.NextDouble() * (max - min) + min, 0, MidpointRounding.ToZero);
        }
    }
    return matrix;
}

void PrintMatrix(double[,] matrix)
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

double[] AverageColumnsElems(double[,] table)
{
    double[] averageArray = new double[table.GetLength(1)];
    for (int j = 0; j < table.GetLength(1); j++)
    {
        double sumColumnsElems = 0;
        double result = 0;
        for (int i = 0; i < table.GetLength(0); i++)
        {
            sumColumnsElems += table[i, j];
        }
        result = Math.Round ((sumColumnsElems / table.GetLength(0)),1);
        averageArray[j] = result;
    }
    return averageArray;
}

void PrintArray(double[] table)
{
    for (int i = 0; i < table.Length; i++)
    {
        if (i < table.Length - 1) Console.Write($"{table[i],4}; ");
        else Console.Write($"{table[i],4}.");
    }
}

double[,] array2d = CreateMatrixRndInt(3, 4, 0, 10);
PrintMatrix(array2d);
double[] averageColumnsElems = AverageColumnsElems(array2d);
Console.WriteLine($"Среднее арифметическое каждого столбца: ");
PrintArray(averageColumnsElems);

