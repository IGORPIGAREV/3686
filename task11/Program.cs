// Задача 11: Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.
// 456 -> 46
// 782 -> 72
// 918 -> 98
int number = new Random().Next(100,1000);
Console.WriteLine(number);
// int number3=number%10;
// int number1=number/100;
Console.WriteLine(number/100*10+number%10);