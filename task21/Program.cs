// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53
Console.WriteLine("Введите кординаты X,Y,Z первой точки:");
Console.WriteLine("Введите кординату Х 1 точки:");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите кординату Y 1 точки:");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите кординату Z 1 точки:");
int z1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите кординаты второй точки:");
Console.WriteLine("Введите кординату Х 2 точки:");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите кординату Y 2 точки:");
int y2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите кординату Z 2 точки:");
int z2 = Convert.ToInt32(Console.ReadLine());
double kvx= Math.Pow((x2-x1),2);
double kvy= Math.Pow((y2-y1),2);
double kvz= Math.Pow((z2-z1),2);
double plane= Math.Sqrt(kvx+kvy+kvz);
Console.WriteLine($"Длина линии между точками:{plane:f2} у.е.");