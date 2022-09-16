// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

// 5 -> 2, 4
// 8 -> 2, 4, 6, 8


// // User input
Console.Clear();
Console.Write("Please, input N = ");

int N = Convert.ToInt32(Console.ReadLine());
int count = 1;
int acc = 0;

while(count <= N)
{
    acc = count % 2;
    if(acc == 0)
    {
        Console.Write($"{count}, ");
    }
    count += 1;
} 
Console.WriteLine();