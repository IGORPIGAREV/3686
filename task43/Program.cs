// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
double Readdouble(string messages)
{
    Console.WriteLine(messages);
    return Convert.ToDouble(Console.ReadLine());
}
double b1 =Readdouble("Введите коэффициент b1 первой пряммой заданой уравнением y = k1 * x + b1:");
double k1 =Readdouble("Введите коэффициент k1 первой пряммой заданой уравнением y = k1 * x + b1:");
double b2 =Readdouble("Введите коэффициент b2 первой пряммой заданой уравнением y = k2 * x + b2:");
double k2 =Readdouble("Введите коэффициент k2 первой пряммой заданой уравнением y = k2 * x + b2:");
double x;
double y;
if (k1==k2)
{
    Console.WriteLine("Линии с такими коэффициент к1 и к2 не пересикаются.");
}
else 
{
    x=(b2-b1)/(k1-k2);
    y=k1*x+b1;
    Console.WriteLine($"Линии пересекутся в точке с координатами х = {x}, y = {y}.");
}