// Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// -3; массив [6, 7, 19, 345, 3] -> да
// Массивы к задачам 32 и 33 можно сделать рандомными. В задаче 33 на экран выводится ТОЛЬКО одно сообщение: либо "да", либо "нет".
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
void serchArray(int[]arr,int num)
{
    string answ="Нет.";
    for (int i=0;i<arr.Length;i++)
    {
        if (arr[i]==num)
        {
            answ="Да.";         
        }
    }
    Console.WriteLine(answ);
}
int[] massive = GetRandomArray(LENGTH, LEFTRANGE, RIGHTRANGE);
Console.WriteLine($"[{string.Join(", ", massive)}]");//Оставлен вывод рандомного массива, для понимания работоспособности программы.
serchArray(massive,5);
