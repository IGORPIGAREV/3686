// Задача 39: Напишите программу, которая перевернёт одномерный массив (последний элемент будет на первом месте, а первый - на последнем и т.д.)
// [1 2 3 4 5] -> [5 4 3 2 1]
// [6 7 3 6] -> [6 3 7 6]
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

