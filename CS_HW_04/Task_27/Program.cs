// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.Clear();
Console.Write("Please, input x = ");
int x = Convert.ToInt32(Console.ReadLine());

int sum = 0;
int i = 0;

while(x > 0)
{
    sum += x % 10;
    x /= 10;
    i++;
}

Console.WriteLine($"The sum of the {i} digits of number is equal: {sum}.");
