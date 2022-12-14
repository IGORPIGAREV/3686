// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0
const int LENGTH = 8;
const int LEFTRANGE = -100;
const int RIGHTRANGE = +100;
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
   int sum=0;
    for (int i=0;i<arr.Length;i++)
    {
        if ( i%2==1 )
        {
            sum=sum+arr[i];         
        }
    }
    Console.WriteLine(sum);
}
int[] massive = GetRandomArray(LENGTH, LEFTRANGE, RIGHTRANGE);
Console.WriteLine($"[{string.Join(", ", massive)}]");//Оставлен вывод рандомного массива, для понимания работоспособности программы.
CountNum(massive);
