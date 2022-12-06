// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// 14212 -> нет

// 12821 -> да

// 23432 -> да
int number=0;
while (number <10000 || number>100000)
{
    Console.WriteLine("Введите пятизначное число :");
    number = Convert.ToInt32(Console.ReadLine());
}
int rebmun=0;
int i=1;
while (rebmun < 10000)
{
    rebmun=rebmun*10;
    rebmun=rebmun+number/i%10;
    i=i*10;   
}
if (number ==rebmun)
{
    Console.WriteLine("Как не верити все одно и тоже!!!");
}
else
Console.WriteLine("Число красивое, но если в зеркало посмотрит себя не узнает.(");  
// int rebmun= 10000* (number%10)+1000*((number/10)%10)+100*(number/100%10)+10*(number/1000%10)+number/10000;


