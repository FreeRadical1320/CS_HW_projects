// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

// 4 -> да
// -3 -> нет
// 7 -> нет

// User input
Console.Clear();
Console.Write("Please, input number: ");

int num = Convert.ToInt32(Console.ReadLine());

int result = num % 2;

// Check the condition
if(result == 1)
{
   Console.WriteLine($"The number {num} is odd");
}
else
{
    Console.WriteLine($"The number {num} is even");
}

