// Задача 62. Напишите программу, 
// которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

int[,] SpiralMatrix(int row, int column)
{
    int temp = 1;
    int[,] spiralMatrix = new int[row, column];
    int pointStartRow = 0;
    int pointFinishRow = 0;
    int pointStartColumn = 0;
    int pointFinishColumn = 0;
    for (int i = 0; i < spiralMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < spiralMatrix.GetLength(1); j++)
        {
            while (temp <= row * column)
                spiralMatrix[i, j] = temp;

            if (i == pointStartRow
                && j < column - pointFinishColumn - 1)
                j++;
            else if (j == column - pointFinishColumn - 1
                     && i < row - pointFinishRow - 1)
                i++;
            else if (i == row - pointFinishRow - 1
                    && j > pointStartColumn)
                j--;
            else
                i--;
            if ((i == pointStartRow + 1) && (j == pointStartColumn)
                && (pointStartColumn != column - pointFinishColumn - 1))
            pointStartRow++;
            pointFinishRow++;
            pointStartColumn++;
            pointFinishColumn++;
        }
        temp++;
    }
    return spiralMatrix;
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
int[,] spiralArray = SpiralMatrix(4, 4);
PrintMatrix(spiralArray);
