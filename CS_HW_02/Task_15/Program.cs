// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

Console.Clear();
Console.Write("Please, input a day of the week = ");

int x = Convert.ToInt32(Console.ReadLine());

if(x > 7 || x < 1)
{
    Console.WriteLine("You have entered wrong number, sorry (");
} 
else if(x == 6 || x == 7)
{
    Console.WriteLine("This day is weekend");
}
else
{
    Console.WriteLine("This day is a workday");
}
