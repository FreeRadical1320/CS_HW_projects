// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.Clear();

Console.WriteLine("Please input M: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Please input N: ");
int n = Convert.ToInt32(Console.ReadLine());


int RangeSum(int m, int n, int res)
{
    if(m > n) return res;
    res += m;
    m++;
    return RangeSum(m, n, res);
}
int res = 0;
Console.WriteLine(RangeSum(m, n, res));