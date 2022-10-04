// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0


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
int[] arr = FillArray(15, -50, 50);

int GetEvenNumSum(int[] arr)
{
    int sum = 0;
    for(int i = 0; i < arr.Length; i++)
    {
        if(i % 2 != 0)
        {
            sum += arr[i];
        }
    }
    return sum;
}
Console.WriteLine($"The sum of the numbers with the odd indexes is {GetEvenNumSum(arr)} .");