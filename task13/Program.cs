// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// 645 -> 5

// 78 -> третьей цифры нет

// 32679 -> 6
Console.WriteLine("Введите число:");
int num = Convert.ToInt32(Console.ReadLine());
if (num < 100) Console.WriteLine("третьей цифры нет"); 
else 
{
    int count= num;
    int index= 1;
    while (count > 999)//Если Заданое число  разрядов наше число больше
    {
        count=count/10;// 
        index=index*10; //Сколько разрядов будем убирать, чтобы получилось 3 значное число.
    }
    Console.WriteLine((num/index)%10);
    
}