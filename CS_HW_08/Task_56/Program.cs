// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7

// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

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

void FindMinRowElementsSum(int[,] arr)
{
    int minSum = 0; 
    int minIndex = 0;
    int rowLength = arr.GetLength(1);

    for(int j = 0; j < rowLength; j++) { minSum += arr[0, j]; }
    
    for (int i = 1; i < arr.GetLength(0); i++)
    {
        int tmpSum = 0;
        for (int j = 0; j < rowLength; j++) { tmpSum += arr[i, j]; }
        if(tmpSum < minSum)
        {
            minSum = tmpSum;
            minIndex = i;
        }
    }
    Console.WriteLine($"The row that has minimum sum of elements has index: {minIndex}.");
}


int[,] arr = FillArray(5, 5, 0, 100);

PrintArray(arr);
Console.WriteLine();
FindMinRowElementsSum(arr);