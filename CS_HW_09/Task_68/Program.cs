// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 29

Console.Clear();

Console.WriteLine("Please input M: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Please input N: ");
int n = Convert.ToInt32(Console.ReadLine());


int AkkermanFunction(int m, int n)
{
    if(m > 0 && n > 0) return AkkermanFunction(m -1 , AkkermanFunction(m, n - 1));
    else if(m > 0 && n == 0) return AkkermanFunction(m -1 , 1);
    else return (n + 1);
}

Console.WriteLine(AkkermanFunction(m, n));