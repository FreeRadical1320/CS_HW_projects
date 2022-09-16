// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

// User input
Console.Clear();
Console.Write("Please, input a = ");

int a = Convert.ToInt32(Console.ReadLine());

Console.Write("Please, input b = ");

int b = Convert.ToInt32(Console.ReadLine());

// Check the condition
if(a > b)
{
    Console.WriteLine($"Number a > b: {a} > {b}");
}
if(a < b)
{
    Console.WriteLine($"Number a < b: {a} < {b}");
}
if(a == b)
{
    Console.WriteLine($"Number a = b: {a} = {b}");
}