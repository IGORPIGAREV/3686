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
int[,]ArrayMultiplication(int[,] arr1, int[,]arr2)
{
    int [,]MultiArray =new int[arr1.GetLength(0),arr1.GetLength(1)]; 
    for (int i=0;i<arr1.GetLength(0);i++)
    {
        for (int j=0; j<arr1.GetLength(1);j++)
        {
            MultiArray[i,j]=arr1[i,j]*arr2[i,j];
        }
    }
    return MultiArray;
    
}
int [,] newmatrix=NewDualArray(4,5,0,9);
PrintDualArray(newmatrix);
Console.WriteLine();
int [,] newmatrix2=NewDualArray(4,5,0,9);
PrintDualArray(newmatrix2);
Console.WriteLine();

if (newmatrix.GetLength(0)==newmatrix2.GetLength(0)&& newmatrix.GetLength(1)==newmatrix2.GetLength(1))
{
    PrintDualArray(ArrayMultiplication(newmatrix,newmatrix2));
}
else
Console.WriteLine("Ерундистика какая то, массивы то не равны...");
