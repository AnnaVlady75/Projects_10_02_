// Задача 57: Составить частотный словарь элементов
// двумерного массива. 
// Частотный словарь содержит
// информацию о том, сколько раз встречается элемент
// входных данных.


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

int[] MatrixToArray(int[,] matrix)
{
    int[] newArray = new int[matrix.Length];
    int k = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            newArray[k] = matrix[i, j];
            k++;
        }
    }
    return newArray;
}

void PrintArray(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]}, ");
        else Console.Write($"{arr[i]}");
    }
    Console.Write("]");
}

void FrequencyDictionaryArray(int[] newArray)
{
    int count = 1;
    int findNumber = newArray[0];
    for (int i = 1; i < newArray.Length; i++)
    {
        if (newArray[i] == findNumber) count++;
        else
        {
            Console.WriteLine($"Число {findNumber} встречается {count} раз");
            findNumber = newArray[i];
            count = 1;
        }
    }
    Console.WriteLine($"Число {findNumber} встречается {count} раз");
}

int[,] array2d = CreateMatrixRndInt(3, 3, 0, 10);
PrintMatrix(array2d);
Console.WriteLine();
int[] array = MatrixToArray(array2d);
Array.Sort(array);
PrintArray(array);
Console.WriteLine();
FrequencyDictionaryArray(array);







