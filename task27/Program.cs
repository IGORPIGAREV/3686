// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11

// 82 -> 10

// 9012 -> 12

int ReadInt(string messages)
{
    Console.WriteLine(messages);
    return Convert.ToInt32(Console.ReadLine());
}
int SumNum(int number)
{
    int sum=0;
    while (number>0)
    {
        sum=sum+number%10;
        number=number/10;
    }
    return sum;
}
int num= ReadInt("Введите число:");
Console.WriteLine(SumNum(num));

