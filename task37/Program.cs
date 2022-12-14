// Задача 37: Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21
const int LENGTH = 13;
const int LEFTRANGE = -9;
const int RIGHTRANGE = 9;
int[] GetRandomArray(int length, int leftRange, int rightRange)
{
    int[] array = new int[length]; 
    Random rand = new Random();
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = rand.Next(leftRange, rightRange + 1);
    }

    return array;
}
int[] sumArray(int[]arr)
{
    int lenght = arr.Length;
    int[] newmasiv=new int[lenght/2+lenght%2];
    if (lenght%2>0) 
    {
        newmasiv[lenght/2]=arr[lenght/2];
    }  
    for (int i=0;i<lenght/2;i++)
    {
        newmasiv[i]=arr[i]*arr[lenght-1-i];
    }
    return newmasiv;
}
int[] massive = GetRandomArray(LENGTH, LEFTRANGE, RIGHTRANGE);
Console.WriteLine($"[{string.Join(", ", massive)}]");
int[] reversmassiv = sumArray(massive);
Console.WriteLine($"[{string.Join(", ", reversmassiv)}]");