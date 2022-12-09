// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16

// Не использовать Math.Pow() и аналоги!
int ReadInt(string messages)
{
    Console.WriteLine(messages);
    return Convert.ToInt32(Console.ReadLine());
}
int MpAnalog(int n1, int n2)
{
    int natst =n1;
    for (int i=1;i<n2;i++)
    {
        natst=natst*n1;
    }
    return natst;
}
int num1 =ReadInt("Введите число число А:");
int num2 =ReadInt("Введите степень числа А:");
Console.WriteLine(MpAnalog(num1,num2));
