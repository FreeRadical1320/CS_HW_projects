// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76

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
int[] arr = FillArray(15, 0, 150);

int GetMaxMinDiff(int[] arr)
{
    int min = arr[0];
    int max = arr[0];
    for(int i = 1; i < arr.Length; i++)
    {
        if(arr[i] > max) max = arr[i];
        if(arr[i] < min) min = arr[i];
        
    }
    return (max - min);
}
Console.WriteLine($"The difference between max and min numbers of array is {GetMaxMinDiff(arr)} .");