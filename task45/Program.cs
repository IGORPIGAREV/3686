// Напишите программу, которая будет создавать копию заданного массива с помощью поэлементного копирования.
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
int[] CoppyArray(int[] arr)
{
    int[] CopyArray=new int[arr.Length];
    for (int i=0;i<arr.Length;i++)
    {
        CopyArray[i]=arr[i];
    }
    return CopyArray;
}
int[] massive = GetRandomArray(LENGTH, LEFTRANGE, RIGHTRANGE);
Console.WriteLine($"[{string.Join(", ", massive)}]");
int[] massive2 = CoppyArray(massive);
massive[5]=454;
Console.WriteLine($"[{string.Join(", ", massive)}]");
Console.WriteLine($"[{string.Join(", ", massive2)}]");