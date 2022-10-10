// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

Console.Clear();

void PrintArray(double[,] arr)
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

double[,] FillArray(int row, int col, double highBorder, int accuracy)
{
    double[,] arr = new double[row, col];
    for(int i = 0; i < row; i++)
    {
        for (int j = 0; j < col; j++)
        {
            arr[i, j] = Math.Round(new Random().NextDouble() * highBorder, accuracy);
        }
    }
    return arr;
}
double[,] arr = FillArray(5, 5, 100, 2);

PrintArray(arr);
