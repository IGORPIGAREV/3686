// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по возрастанию элементы каждой строки двумерного массива.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// В итоге получается вот такой массив:

// 1 2 4 7

// 2 3 5 9

// 2 4 4 8
int[,] NewDualArray(int rows,int columns, int leftRange,int rightRange)
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
void RowsSorting(int[,] array)
{
    int count;
    int temp;
    for (int i=0;i<array.GetLength(0);i++)
    {
        count=array.GetLength(1);
        for (int k=0;k<array.GetLength(1)-1;k++)
        {
            for (int j=0;j<count-1;j++)
            {
                if (array[i,j]>array[i,j+1])
                {
                    temp=array[i,j];
                    array[i,j]=array[i,j+1];
                    array[i,j+1]=temp;
                }
            }
            count--;
        }
    }
}
int [,] newmatrix=NewDualArray(4,6,0,30);
PrintDualArray(newmatrix);
RowsSorting(newmatrix);
Console.WriteLine();
PrintDualArray(newmatrix);