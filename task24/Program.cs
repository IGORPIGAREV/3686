// Задача 24: Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.
// 7 -> 28
// 4 -> 10
// 8 -> 36
int ReadInt(string messages)
{
    Console.WriteLine(messages);
    return Convert.ToInt32(Console.ReadLine());
}

int GetSumToNumber(int num)
{
    int sum =0;
    for (int i=0;i<=num;i++)
    {
    sum=sum+i;
    }
    return sum;
}

int A =ReadInt("Введите числ:");
int result= GetSumToNumber(A);
Console.WriteLine($"Сумма чисел от 1 до {A} = {result}");