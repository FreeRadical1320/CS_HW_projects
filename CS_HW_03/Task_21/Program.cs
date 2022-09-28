// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.Clear();
Console.Write("Please, input xa = ");

int xa = Convert.ToInt32(Console.ReadLine());

Console.Write("Please, input ya = ");

int ya = Convert.ToInt32(Console.ReadLine());

Console.Write("Please, input za = ");

int za = Convert.ToInt32(Console.ReadLine());

Console.WriteLine();

Console.Write("Please, input xb = ");

int xb = Convert.ToInt32(Console.ReadLine());

Console.Write("Please, input yb = ");

int yb = Convert.ToInt32(Console.ReadLine());

Console.Write("Please, input zb = ");

int zb = Convert.ToInt32(Console.ReadLine());

double distance = Math.Sqrt(Math.Pow((xb - xa), 2) + Math.Pow((yb - ya), 2)  + Math.Pow((zb - za), 2));


Console.WriteLine($"The distance between A({xa}, {ya}, {za}) and B({xb}, {yb}, {zb}) is equal: {Math.Round(distance, 2)}.");




