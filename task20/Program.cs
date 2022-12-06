// Задача 20: Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.
// A (3,6); B (2,1) -> 5,09
// A (7,-5); B (1,-1) -> 7,21
Console.WriteLine("Введите кординаты первой точки:");
Console.WriteLine("Введите кординату Х 1 точки:");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите кординату Y 1 точки:");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите кординату Х 2 точки:");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите кординату Y 2 точки:");
int y2 = Convert.ToInt32(Console.ReadLine());
double kvx= Math.Pow((x2-x1),2);
double kvy= Math.Pow((y2-y1),2);
double plane= Math.Sqrt(kvx+kvy);
Console.WriteLine($"Длина линии между точками:{plane:f5}");
