// Задача 22: Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел от 1 до N.
// 5 -> 1, 4, 9, 16, 25.
// 2 -> 1,4
Console.WriteLine("Введите число:");
int num = Convert.ToInt32(Console.ReadLine());
int k = 1;
if (num<0) 
{
    k=k*-1;
}
int i=1;
double kvi= Math.Pow(i,2);
Console.Write(kvi);
while (i<num*k)
{
    i++;
    kvi= Math.Pow(i,2);
    Console.Write($", {kvi}");
}
