// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

// User input
Console.Clear();
Console.Write("Please, input number 1: ");

int a = Convert.ToInt32(Console.ReadLine());

Console.Write("then number 2: ");

int b = Convert.ToInt32(Console.ReadLine());

Console.Write("and number 3: ");

int c = Convert.ToInt32(Console.ReadLine());

int max = a;

// Check the condition
if(a > max)
{
   max = a;
}
if(b > max)
{
    max = b;
}
if(c > max)
{
    max = c;
}

Console.WriteLine($"The max number is: {max}");