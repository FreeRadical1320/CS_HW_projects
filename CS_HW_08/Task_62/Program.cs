// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07


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

int[,] FillSpiralArray(int dim)
{
    int[,] arr = new int[dim, dim];
    int i = 0, j = 0, k = 1;
    arr[i, j] = k;
    int nElements = dim * dim;
    while(k < nElements)
    {
        k++;
        if((i - 1) > -1 && arr[i - 1, j] == 0
            && (j + 1) < dim && arr[i, j + 1] == 0) {i--;}
            
        else if((j + 1) < dim && arr[i, j + 1] == 0) {j++;}

        else if((i + 1) < dim && arr[i + 1, j] == 0) {i++;}
        
        else if((j - 1) > -1 && arr[i, j - 1] == 0) {j--;}
        
        else if((i - 1) > -1 && arr[i - 1, j] == 0) {i--;}
      
        arr[i, j] = k;
    }
    return arr;
}


int[,] arr = FillSpiralArray(4);
Console.WriteLine($"");
PrintArray(arr);
