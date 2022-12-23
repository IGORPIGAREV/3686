// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// ​
// m = 3, n = 4.
// ​
// 0,5 7 -2 -0,2
// ​
// 1 -3,3 8 -9,9
// ​
// 8 7,8 -7,1 9
int ReadInt(string messages)
{
    Console.WriteLine(messages);
    return Convert.ToInt32(Console.ReadLine());
}

double[,] NewDualArray(int rows,int columns, int leftRange=0,int rightRange=12)

{
    double[,] array=new double[rows,columns];
    Random rand = new Random();
    for (int i=0;i<rows;++i)
    {
        for (int j=0;j<columns;++j)
        {
            array[i,j]=rand.Next(-5,5)+rand.NextDouble();
        }
    }  
    return array;
}
void PrintDualArray(double[,]arr)
{
    for (int i=0;i<arr.GetLength(0);++i)
    {
        Console.Write("[");
        for (int j=0;j<arr.GetLength(1);++j)
        {
            Console.Write ($"{arr[i,j]:f1} ");
        }
        Console.WriteLine("]");
    } 
}
int row = ReadInt("Введите колличество строк массива:");
int column = ReadInt("Введите колличество столбцов массива:");
// int leftRange = ReadInt("Введите минимальное значение целого числа в массиве:");
// int rightRange = ReadInt("Введите минимальное значение целого числа в массиве:");
PrintDualArray(NewDualArray(row,column));