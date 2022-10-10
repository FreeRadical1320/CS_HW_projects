// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

Console.Clear();

void PrintArray(int[,] arr)
{
    for(int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i, j]}\t");
        }
        Console.WriteLine();
    }
}

int[,] FillArray(int row, int col, int lowBorder, int highBorder)
{
    int[,] arr = new int[row, col];
    for(int i = 0; i < row; i++)
    {
        for (int j = 0; j < col; j++)
        {
            arr[i, j] = new Random().Next(lowBorder, highBorder + 1);
        }
    }
    return arr;
}

void GetColumnsMeanValues(int[,] arr)
{
    int nColumns = arr.GetLength(1);
    int nRows = arr.GetLength(0);
    double[] means = new double[nColumns];

    for(int j = 0; j < nColumns; j++)
    {
        double sum = 0;
        for (int i = 0; i < nRows; i++)
        {
            sum += arr[i, j];
        }
        means[j] = Math.Round((sum / nRows), 3);
        Console.Write($"{means[j]}\t");
    }
    Console.WriteLine();
}

int[,] arr = FillArray(5, 5, 100, 999);


PrintArray(arr);
Console.WriteLine();

GetColumnsMeanValues(arr);
