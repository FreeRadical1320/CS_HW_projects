// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.Clear();
Console.Write("Please, input a number consists of 5 digits = ");

int x = Convert.ToInt32(Console.ReadLine());

int[] digits = new int[5];

for(int i = 0; i < 5; i++)
{
    digits[i] = x % 10;
    x = x / 10;
}
if(x != 0)
{
    Console.WriteLine($"You,ve entered wrong number!!! It consists of more then 5 digits");
}
else
{
    int j = 0;
    string isPolindrom = string.Empty;
    for(int i = 0; i < digits.Length; i++)
    {
        j = (digits.Length -1) - i;
        if(digits[i] !=  digits[j]) 
        {
            isPolindrom = "not ";
            break;
        }
    }
    Console.WriteLine($"Number is {isPolindrom}polindrom.");
}

