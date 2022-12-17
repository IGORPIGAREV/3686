// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь. Ввод чисел останавливается при помощи ввода слова "stop"

// 0, 7, 8, -2, -2 -> 2

// 1, -7, 567, 89, 223-> 4

string stopword="чебурек";
string text=String.Empty;
int count=0;
int num;
while (text.ToLower()!=stopword)
{
    Console.WriteLine("Введите число :");
    text = Console.ReadLine();
    if (text.ToLower()!=stopword)
    {
        num=Convert.ToInt32(text);
        if (num>0)
        {
            count++;
        }
    }
    
}
Console.WriteLine($"Чисел больше 0:{count}");