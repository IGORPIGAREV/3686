// Задача 28: Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
// 4 -> 24
// 5 -> 120
int ReadInt(string messages)
{
    Console.WriteLine(messages);
    return Convert.ToInt32(Console.ReadLine());
}
int proiz(int num)
{
   
    int i =1;
    int pro=1;
    while (i!=num)
    {
    i++;
    pro=pro*i;
    }
    return pro;

}

int A =ReadInt("Введите число:");
int result=proiz(A);
Console.WriteLine(result);