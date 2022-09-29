// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]


int[] arr = new int[8];

for(int i = 0; i < 8; i++)
{
    Console.Write($"Please, input  number {i + 1}: ");
    arr[i] = Convert.ToInt32(Console.ReadLine());
}

Console.Write("[");
for(int i = 0; i < 8; i++)
{
    Console.Write($"{arr[i]}, ");
}
Console.WriteLine("]");