// Задача 38: Задайте массив 
// вещественных чисел. Найдите 
// разницу между максимальным и минимальным 
// элементов массива.
// [3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2

double[] CreateArrayRndDouble(int size, int min, int max)
{
    double[] arr = new double[size];
    Random rnd = new Random();
    for (int i = 0; i < size; i++)
    {
        arr[i] = Math.Round(rnd.NextDouble() * (max - min) + min, 1, MidpointRounding.ToZero);
    }
    return arr;
}

void PrintArrayDouble(double[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]}; ");
        else Console.Write($"{arr[i]}");
    }
    Console.Write("]");
}

double MaxElems(double[] arr)
{
    double max = arr[0];
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > max)
            max = arr[i];
    }
    return max;
}

double MinElems(double[] arr)
{
    double min = arr[0];
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] < min)
            min = arr[i];
    }
    return min;
}

double[] array = CreateArrayRndDouble(5, -100, 100);
PrintArrayDouble(array);
Console.Write(" -> ");
double diffMaxMin = MaxElems(array) - MinElems(array);
Console.WriteLine(Math.Round(diffMaxMin, 1, MidpointRounding.ToZero));

