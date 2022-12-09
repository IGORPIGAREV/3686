// Задача 29: Напишите программу,
// которая задаёт массив из 8 элементов и выводит их на экран. Данные вводятся с консоли пользователем
int ReadArr(int index)
{
    Console.WriteLine($"Введите элементm массива с индексом {index}");
    return Convert.ToInt32(Console.ReadLine());
}
void InpArry(int[]arr)
{
    for (int i=0; i<arr.Length; i++)
    {
        arr[i]=ReadArr(i);
    }
}
int[] arry= new int[8];
InpArry(arry);
Console.WriteLine($"[{string.Join(", ",arry)}]");
