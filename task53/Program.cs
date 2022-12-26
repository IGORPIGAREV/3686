// Задача 53: Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.
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
void Chengerows(int[,]arr)
{
    int temp=0;
    for (int j=0;j<arr.GetLength(1);++j)
    {
        temp=arr[0,j];
        arr[0,j]=arr[arr.GetLength(0)-1,j];
        arr[arr.GetLength(0)-1,j]=temp;
    } 
}
int [,] newmatrix=NewDualArray(5,5,0,10);
PrintDualArray(newmatrix);
Console.WriteLine();
Chengerows(newmatrix);
PrintDualArray(newmatrix);


