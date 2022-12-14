// Задача 32: Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2]
const int LENGTH = 12;
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
int[] ReversArray(int[]arr)
{
    int count=0;
    for (int i=0;i<LENGTH;i++)
    {
        count=arr[i];
        arr[i]=count*-1;
    }
    return arr;
}
int[] massive = GetRandomArray(LENGTH, LEFTRANGE, RIGHTRANGE);
Console.WriteLine($"[{string.Join(", ", massive)}]");
int[] reversmassiv = ReversArray(massive);
Console.WriteLine($"[{string.Join(", ", reversmassiv)}]");