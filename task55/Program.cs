// // Задача 55: Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы.
//  В случае, если это невозможно, программа должна вывести сообщение для пользователя.a
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
int[,] Chengerowscolums(int[,]arr)
{
    int[,] array=new int[arr.GetLength(1),arr.GetLength(0)];
        for (int j=0;j<arr.GetLength(1);++j)
    {
        for (int i=0;i<arr.GetLength(0);++i)
        {
            array[j,i]=arr[i,j];
        }
    }
    return array; 
}
int [,] newmatrix=NewDualArray(4,4,0,10);
PrintDualArray(newmatrix);
int [,]trixnwema=Chengerowscolums(newmatrix);
PrintDualArray(trixnwema);