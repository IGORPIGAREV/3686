// Задача 59: Задайте двумерный массив из целых чисел. Напишите программу, которая удалит строку и столбец, на пересечении которых расположен наименьший элемент массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Наименьший элемент - 1, на выходе получим
// следующий массив:
// 9 4 2
// 2 2 6
// 3 4 7
int[,] NewDualArray(int rows,int columns, int leftRange,int rightRange)
{
    int[,] array=new int[rows,columns];
    PrintDualArray(array);
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
(int,int) minArray(int[,]arr)
{
    int mini=0;
    int minj=0;
    for (int i=0;i<arr.GetLength(0);i++)
    {
            for (int j=0;j<arr.GetLength(1);j++)
        {
            if (arr[mini,minj]>arr[i,j])
            {
                mini=i;
                minj=j;
            }
        }
    }
    return (mini,minj); 
}
int[,] Chengerowscolums(int[,]arr)
{
    (int mini,int minj)=minArray(arr);
    Console.WriteLine ($"{mini},{minj} ");
    int[,] array=new int[arr.GetLength(0)-1,arr.GetLength(1)-1];
    int k1=0;
    int k2=0;
        for (int i=0;i<arr.GetLength(0)-1;i++)
    {
         if (i==mini)
            {
                k1++;
            }
        for (int j=0;j<arr.GetLength(1)-1;j++)
        {
            if (j==minj)
            {
                k2++;
            }
            array[i,j]=arr[i+k1,j+k2];
        }
        k2=0;
    }
    return array; 
}
int [,] newmatrix=NewDualArray(4,4,0,9);
PrintDualArray(newmatrix);
int [,]trixnwema=Chengerowscolums(newmatrix);
PrintDualArray(trixnwema);
