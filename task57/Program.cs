// Задача 57: Составить частотный словарь элементов двумерного массива. Частотный словарь содержит информацию о том, сколько раз встречается элемент входных данных.
// 1, 2, 3
// 4, 6, 1
// 2, 1, 6

// 1 встречается 3 раза
// 2 встречается 2 раз
// 3 встречается 1 раз
// 4 встречается 1 раз
// 6 встречается 2 раза
// В нашей исходной матрице встречаются элементы от 0 до 9
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
int minArray(int[,]arr)
{
    int min=0;
    for (int i=0;i<arr.GetLength(0);++i)
    {
            for (int j=0;j<arr.GetLength(1);++j)
        {
            if (min>arr[i,j])
            min=arr[i,j];
        }
    }
    return min; 
}
int maxArray(int[,]arr)
{
    int max=0;
    for (int i=0;i<arr.GetLength(0);++i)
    {
            for (int j=0;j<arr.GetLength(1);++j)
        {
            if (max<arr[i,j])
            max=arr[i,j];
        }
    }
    return max; 
}
void countDualArray(int[,]arr)
{
    int min = minArray(arr);
    int max = maxArray(arr);
    int count;
    for (int i=min;i<=max;i++)
    {
        count=0;
        for(int j=0;j<arr.GetLength(0);j++)
        {
            for (int k=0;k<arr.GetLength(1);k++)
            {
                if (arr[j,k]==i)
                {
                    count++;
                }
            }
        }
        if (count>0)
        {
            Console.WriteLine($"{i} встречается {count} раза");
        }
    }  
}
int [,] newmatrix=NewDualArray(4,4,0,9);
PrintDualArray(newmatrix);
countDualArray(newmatrix);
//PrintDualArray(newmatrix);