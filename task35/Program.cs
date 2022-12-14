// Задача 35: Задайте одномерный массив из 123 случайных чисел в диапазоне [0, 150]. Найдите количество элементов массива, значения которых лежат в отрезке [10,99].
// Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5
const int LENGTH = 123;
const int LEFTRANGE = 0;
const int RIGHTRANGE = 150;
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
void CountNum(int[]arr, int minr, int maxr)
{
   int count=0;
    for (int i=0;i<arr.Length;i++)
    {
        if ( minr <= arr[i] && arr[i] <= maxr )
        {
            count++;         
        }
    }
    Console.WriteLine(count);
}
int[] massive = GetRandomArray(LENGTH, LEFTRANGE, RIGHTRANGE);
Console.WriteLine($"[{string.Join(", ", massive)}]");//Оставлен вывод рандомного массива, для понимания работоспособности программы.
CountNum(massive,10,99);