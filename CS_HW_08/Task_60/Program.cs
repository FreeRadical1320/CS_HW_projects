// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

Console.Clear();

void PrintArray(int[,,] arr)
{
    for(int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            for (int k = 0; k < arr.GetLength(2); k++)
            {
                Console.Write($"{arr[i, j, k]} ({i}, {j}, {k})\t");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}

int[,,] FillArray(int xScale, int yScale, int zScale, int start)
{
    int[,,] arr = new int[xScale, yScale, zScale];
    for(int i = 0; i < xScale; i++)
    {
        for (int j = 0; j < yScale; j++)
        {
            for (int k = 0; k < zScale; k++)
            {
                arr[i, j, k] = start;
                start++;
            }
            start += 3;
        }
        start += 2;
    }
    return arr;
}

int[,,] arr = FillArray(3, 3, 3, 10);

PrintArray(arr);
