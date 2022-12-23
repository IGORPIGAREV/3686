// Задача 46: Задайте двумерный массив размером m×n, заполненный случайными целыми числами.
// m = 3, n = 4.
// 1 4 8 19
// 5 -2 33 -2
// 77 3 8 1
int ReadInt(string messages)
{
    Console.WriteLine(messages);
    return Convert.ToInt32(Console.ReadLine());
}

int[,] NewDualArray(int rows,int columns, int leftRange=0,int rightRange=12)

{
    int[,] array=new int[rows,columns];
    Random rand = new Random();
    for (int i=0;i<rows;++i)
    {
        for (int j=0;j<columns;++j)
        {
            array[i,j]=rand.Next(leftRange,rightRange+1);
        }
    }  
    return array;
}
void PrintDualArray(int[,]arr)
{
    for (int i=0;i<arr.GetLength(0);++i)
    {
        Console.Write("[");
        for (int j=0;j<arr.GetLength(1);++j)
        {
            Console.Write ($"{arr[i,j]} ");
        }
        Console.WriteLine("]");
    } 
}
int row = ReadInt("Введите колличество строк массива:");
int column = ReadInt("Введите колличество столбцов массива:");
// int leftRange = ReadInt("Введите минимальное значение целого числа в массиве:");
// int rightRange = ReadInt("Введите минимальное значение целого числа в массиве:");
PrintDualArray(NewDualArray(row,column));
