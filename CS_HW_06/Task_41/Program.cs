// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3
Console.Clear();
int count = 0;

while(true)
{
    Console.Write("Please, input next number: ");

    int x = Convert.ToInt32(Console.ReadLine());

    if(x > 0) 
    {
        count++;
        Console.WriteLine($"You have inputed {count} positive numbers.");
    }
    
    Console.Write("Do you want to finish? y/n: ");
    string cmd = Convert.ToString(Console.ReadLine());
    if(cmd == "y") break;
}