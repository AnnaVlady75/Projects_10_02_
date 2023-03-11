// Задача 58: Задайте две матрицы. 
// Напишите программу, которая будет 
// находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4  2*3+4*3 = 18  2*4+4*3 = 20
// 3 2 | 3 3  3*3+2*3 = 15  3*4+2*3 = 18
// Результирующая матрица будет:
// 18 20
// 15 18

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

int[,] AverageTwoMatrixs(int[,] matrixA, int[,] matrixB)
{
    int rowA = matrixA.GetLength(0), columnA = matrixA.GetLength(1);
    int rowB = matrixB.GetLength(0), columnB = matrixB.GetLength(1);
    int[,] matrixC = new int[rowA, columnB];

    for (int i = 0; i < rowA; i++)
    {
        for (int j = 0; j < columnB; j++)
        {
            for (int k = 0; k < columnA; k++)
            {
                matrixC[i, j] += matrixA[i, k] * matrixB[k, j];
            }
        }
    }
    return matrixC;
}

int[,] array2dA = CreateMatrixRndInt(2, 3, 0, 10);
PrintMatrix(array2dA);
Console.WriteLine();
int[,] array2dB = CreateMatrixRndInt(3, 2, 0, 10);
PrintMatrix(array2dB);
Console.WriteLine();
int[,] array2dC = AverageTwoMatrixs(array2dA, array2dB);
if (array2dA.GetLength(1) == array2dB.GetLength(0))
    PrintMatrix(array2dC);
else Console.Write($"Умножение не возможно!");

