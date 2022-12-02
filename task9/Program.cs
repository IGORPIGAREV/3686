// Задача 9. Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.
// 78 -> 8
// 12-> 2
// 85 -> 8
int number = new Random().Next(10,100);
Console.WriteLine(number);
if (number%10>number/10) Console.WriteLine(number%10);
else Console.WriteLine(number/10);
