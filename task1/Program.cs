// Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго.
// a = 25, b = 5 -> да
// a = 2, b = 10 -> нет
// a = 9, b = -3 -> да
// a = -3 b = 9 -> нет
Console.Write("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());
int NClone = 0;
for(int arg = N; arg > 0; arg = arg / 10)
{
    NClone = (NClone * 10) + (arg % 10);
}
//Console.WriteLine($"{N},{NClone}");//Выыод исходного числа и перевернутого
if(N == NClone)
{
    Console.WriteLine("Число полиндром");
}
else Console.WriteLine("Число не полиндром");


