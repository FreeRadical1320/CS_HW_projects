// Задача 64: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5. -> "1, 2, 3, 4, 5"
// M = 4; N = 8. -> "4, 6, 7, 8"

void PrintNumbers(int N, int n)
{
    if(N >= n) 
    {
        Console.Write($"{N}, ");
        PrintNumbers(--N, n);
    }
    return;
}

Console.Clear();
Console.WriteLine("Please input N: ");
int N = Convert.ToInt32(Console.ReadLine());


PrintNumbers(N, 1);
Console.WriteLine();

