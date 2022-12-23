// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// ​
// Например, задан массив:
// ​
// 1 4 7 2
// ​
// 5 9 2 3
// ​
// 8 4 2 4
// ​
// 1 7 -> такого числа в массиве нет
int ReadInt(string messages)
{
    Console.WriteLine(messages);
    return Convert.ToInt32(Console.ReadLine());
}

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
void ElementSearch(int[,]Array)
{
    int СellRow = ReadInt("Введите номер строки элемента :");
    int СellColumn = ReadInt("Введите номер столбца элемента :");
    if (Array.GetLength(0)>СellRow && Array.GetLength(1)>СellColumn )
    {
        Console.WriteLine(Array[СellRow,СellColumn]);
    }
    else
    {
        Console.WriteLine("Такого элемента в массиве нет.");
    }
}
int [,] newmatrix=NewDualArray(5,5,0,10);
PrintDualArray(newmatrix);
ElementSearch(newmatrix);

