// for (int count=0; count != 5;)
// {
//     Console.WriteLine("Введите пятизначное число :");
//     string text = Console.ReadLine();
//     count = text.Length;
//     if (count!=5) Console.WriteLine("Мимо!"); 
// }
int count=0;
string text=String.Empty;
while (count != 5)
{
    Console.WriteLine("Введите пятизначное число :");
    text = Console.ReadLine();
    count = text.Length;
    if (count!=5) Console.WriteLine("Мимо!");
}
// Console.WriteLine("Введите пятизначное число :");
// string text = Console.ReadLine();
// int count = text.Length;
// int cu=Convert.ToInt32(text);

string answer=String.Empty;
for (int i = 0; i < count; i++)
{
    count = count-1;
    if (text[i] != text[count])
    {
        answer="нет";
        break;
    }
    else answer="да"; 
}
Console.Write(cu+1); 