// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу,
// которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер
// строки с наименьшей суммой элементов: 1 строка
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
void FindMinSumRows(int[,] array)
{
    int sum;
    int summin=0;
    int indsummin=0;
    for (int i=0;i<array.GetLength(0);i++)
    {
        sum=0;
        for (int j=0;j<array.GetLength(1);j++)
        {
            sum+=array[i,j];
        }
        // Console.WriteLine(sum);// чтоб посмотреть сумму по строкам.
        if (i==0)
        {
            summin=sum;
            indsummin=i;
        }
        else
        {
            if (sum<summin)
            {
                summin=sum;
                indsummin=i;
            }
        }
    }
    Console.WriteLine($"Строка с наименьшей суммой элементов:{indsummin+1}");
    //Выдает именно номер строки а не индекс.
}
int [,] newmatrix=NewDualArray(4,6,0,10);
PrintDualArray(newmatrix);
FindMinSumRows(newmatrix);



