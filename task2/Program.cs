// Задача 21: Напишите программу, которая принимает на вход координаты двух точек 
// и находит расстояние между ними в 3D пространстве.

Console.WriteLine("Введите координаты первой точки через пробел X Y Z:");
string x1y1z1 = Console.ReadLine()!;  
string[] parts1 = x1y1z1.Split(' ');
int x1 = int.Parse(parts1[0]);
int y1 = int.Parse(parts1[1]);
int z1 = int.Parse(parts1[2]);

Console.WriteLine("Введите координаты второй точки через пробел X Y Z:");
string x2y2z2 = Console.ReadLine()!;  
string[] parts2 = x2y2z2.Split(' ');
int x2 = int.Parse(parts2[0]);
int y2 = int.Parse(parts2[1]);
int z2 = int.Parse(parts2[2]);
double dis = Math.Sqrt(Math.Pow(x2-x1, 2) + Math.Pow(y2-y1, 2) + Math.Pow(z2-z1, 2));
Console.WriteLine($"Растояние между точками равно: {dis:F3}");
