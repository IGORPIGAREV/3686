// Задача 26: Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5
int ReadInt(string messages)
{
    Console.WriteLine(messages);
    return Convert.ToInt32(Console.ReadLine());
}
int Razryd(int num)
{
    int i=0;
    for (i=0; num!=0;i++)
    num=num/10;
    return i;
}

int A =ReadInt("Введите число:");
int result=Razryd(A);
Console.WriteLine(result);