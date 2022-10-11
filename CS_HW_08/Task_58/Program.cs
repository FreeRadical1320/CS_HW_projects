// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

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

int GetNewElement(int k, int l, int[,] arrA, int[,] arrB)
{
    int element = 0;

    for (int i = 0; i < arrA.GetLength(1); i++)
    {
        element += arrA[k, i] * arrB[i, l];
    }
    return element;
}

int[,] ProductMatrix(int[,] arrA, int[,] arrB)
{
    int row = arrA.GetLength(0); 
    int col = arrB.GetLength(1);

    int[,] arrC = new int[row, col];

    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < col; j++)
        {
            arrC[i, j] = GetNewElement(i, j, arrA, arrB); 
        }
    }
    return arrC;
}


int[,] arrA = FillArray(2, 2, 0, 10);
Console.WriteLine($"Matrix A.");
PrintArray(arrA);

int[,] arrB = FillArray(2, 2, 0, 10);
Console.WriteLine($"Matrix B.");
PrintArray(arrB);
Console.WriteLine($"The result of production matrix C.");
PrintArray(ProductMatrix(arrA, arrB));