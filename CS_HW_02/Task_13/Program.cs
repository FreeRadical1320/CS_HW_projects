// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.Clear();
Console.Write("Please, input x = ");

int x = Convert.ToInt32(Console.ReadLine());

Console.Write("Input which right digit do you want to find: ");

int nRight = Convert.ToInt32(Console.ReadLine());


int rightDigit = -1;

for(int i = 0; i < nRight; i++)
{
    if(x != 0)
    {
        rightDigit = x % 10;
        x /= 10;
    }
    else
    {
        Console.WriteLine($"{nRight} digit is not exist!");
        break;
    }
}

Console.WriteLine($"{nRight} digit is {rightDigit}");