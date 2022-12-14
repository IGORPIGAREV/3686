// Задача 38: Задайте массив натуральных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76
const int LENGTH = 8;
const int LEFTRANGE = 1;
const int RIGHTRANGE = 100;
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
void CountNum(int[]arr)
{
   int maxn=arr[0];
   int minn=arr[0];

    for (int i=0;i<arr.Length;i++)
    {
        if (arr[i]>maxn)
        {
            maxn=arr[i];         
        }
        if (arr[i]<minn)
        {
            minn=arr[i];         
        }
    }
    Console.WriteLine(maxn-minn);
}
int[] massive = GetRandomArray(LENGTH, LEFTRANGE, RIGHTRANGE);
Console.WriteLine($"[{string.Join(", ", massive)}]");//Оставлен вывод рандомного массива, для понимания работоспособности программы.
CountNum(massive);