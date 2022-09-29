// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.Clear();
Console.Write("Please, input A = ");

int A = Convert.ToInt32(Console.ReadLine());

Console.Write("Please, input B = ");

int B = Convert.ToInt32(Console.ReadLine());

int prod = 1;

for(int i = 1; i <= B; i++)
{
   prod *= A ;
}
Console.WriteLine($"A raised to the power of B is equal: {prod}."); 