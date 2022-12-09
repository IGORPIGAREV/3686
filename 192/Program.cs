string InputCheck()// метод ввода и проверки данных.
{
int count=0;
string text=String.Empty;
while (count != 5)
{
    Console.WriteLine("Введите пятизначное число :");
    text = Console.ReadLine();
    count = text.Length;
    if (count!=5) Console.WriteLine("Мимо!"); 
}
return text;
}
void polydrome(string text)
{   
    string answer=String.Empty;
    int count = text.Length;
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
Console.Write(answer); 
}
polydrome(InputCheck());

 
