// Доп. задание
// Написать метод для разворота массива, не используя память под дополнительный массив
void FillArray(int[] collections) //void - метод ничего не возвращает(Заполняет массив)
{
    int length = collections.Length;
    int index = 0;
    while (index< length)
    {
        collections[index]=new Random().Next(1, 10);
        index++;
    }
}
void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.Write(col[position]);
        position++;
    }
    Console.WriteLine();
}
void ReversArray(int[] col)
{
    int count = (col.Length)-1;
    int position = 0;
    int vrem;
    while (position < count)
    {
        vrem =col[position];
        col[position]=col[count];
        col[count]=vrem;
        position++;
        count--;
    }
}
int[]array = new int[12];
FillArray(array);
PrintArray(array);
Console.WriteLine("А теперь развернем:");
ReversArray(array);
PrintArray(array);