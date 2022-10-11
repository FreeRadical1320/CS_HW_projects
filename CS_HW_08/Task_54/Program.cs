// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2
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

int[,] SortArrayRowsDesc(int[,] arr)
{
    int buff = 0; 
    int max = 0;
    int rowLength = arr.GetLength(1);
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < rowLength; j++)
        {
            for(int k = j + 1; k < rowLength; k++)
            {
                if(arr[i, k] > arr[i, j])
                {
                    buff = arr[i, j] ;
                    arr[i, j] = arr[i, k];
                    arr[i, k] = buff;
                }
            }
        }
    }
    
    return arr;
}


int[,] arr = FillArray(5, 5, 100, 1000);

PrintArray(arr);
Console.WriteLine();
PrintArray(SortArrayRowsDesc(arr));