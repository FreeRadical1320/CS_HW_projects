// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет
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

Console.Write("Please, input row number: ");
int row = Convert.ToInt32(Console.ReadLine());

Console.Write("Please, input column number: ");
int col = Convert.ToInt32(Console.ReadLine());

PrintArray(arr);

row -= 1;
col -= 1;

string isExist = String.Empty;
if(row > 0
    && row < arr.GetLength(0)
    && col > 0
    && col < arr.GetLength(1)
) {isExist = Convert.ToString(arr[row, col]);}
else {isExist = "not exist";}

Console.WriteLine($"The element with indexes row = {row + 1} and column = {col + 1} is {isExist}.");