// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет
Console.WriteLine("Введите номер дня недели:");
int number = Convert.ToInt32(Console.ReadLine());
if (number == 6 || number==7) Console.WriteLine("Ура выходной!!!");
else if (number>0 && number<7) Console.WriteLine("Нет, не хочу на работу!");
else Console.WriteLine("Вы изобрили новый день недили!!!");