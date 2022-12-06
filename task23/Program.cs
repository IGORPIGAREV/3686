// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125
Console.WriteLine("Введите число:");
int num = Convert.ToInt32(Console.ReadLine());
int k = 1;
if (num<0) 
{
    k=k*-1;
}
int i=1;
double kvi= Math.Pow(i*k,3);
Console.Write(kvi);
while (i<num*k)
{
    i++;
    kvi= Math.Pow(i*k,3);
    Console.Write($", {kvi}");
}

