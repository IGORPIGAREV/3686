//  Напишите программу, которая по заданному номеру четверти, показывает
//  диапазон возможных координат точек в этой четверти (x и y).
Console.WriteLine("Введите номер четверити:");
int number1 = Convert.ToInt32(Console.ReadLine());
if (number1<1||number1>1) 
{
    Console.WriteLine("Не коректный номер четверти:");
}
if (number1==1) 
{
    Console.WriteLine("В этой четверти X>0 и Y>0");
}
if (number1==2) 
{
    Console.WriteLine("В этой четверти X<0 и Y>0");
}
if (number1==3) 
{
    Console.WriteLine("В этой четверти X<0 и Y<0");
}
if (number1==4) 
{
    Console.WriteLine("В этой четверти X>0 и Y<0");
}