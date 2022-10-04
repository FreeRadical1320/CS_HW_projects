// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

int[] FillArray(int lng, int lowBorder, int highBorder)
{
    int[] arr = new int[lng];
    for(int i = 0; i < lng; i++)
    {
        arr[i] = new Random().Next(lowBorder, highBorder + 1);
        Console.Write($"{arr[i]}\t");
    }
    Console.WriteLine();
    return arr;
}
int[] arr = FillArray(15, 100, 999);

int FindEvenNumInArray(int[] arr)
{
    int nEven = 0;
    for(int i = 0; i < arr.Length; i++)
    {
        if(arr[i] % 2 == 0)
        {
            nEven++;
        }
    }
    return nEven;
}
Console.WriteLine($"There are {FindEvenNumInArray(arr)} even numbers in array.");