// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2
const int LENGTH = 12;
const int LEFTRANGE = 100;
const int RIGHTRANGE = 1000;
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
void EwenNum(int[]arr)
{
   int count=0;
    for (int i=0;i<arr.Length;i++)
    {
        if (arr[i]%2==0)
        {
            count++;         
        }
    }
    Console.WriteLine(count);
}
int[] massive = GetRandomArray(LENGTH, LEFTRANGE, RIGHTRANGE);
Console.WriteLine($"[{string.Join(", ", massive)}]");//Оставлен вывод рандомного массива, для понимания работоспособности программы.
EwenNum(massive);