// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// ​
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
// int ReadInt(string messages)
// {
//     Console.WriteLine(messages);
//     return Convert.ToInt32(Console.ReadLine());
// }
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
void AverageValueColumns(int[,]arr)
{
    double avg=0;
    for (int j=0;j<arr.GetLength(1);++j)
    {
        Console.Write($"Среднее значение столбца {j} =");
        avg=0;
        for (int i=0;i<arr.GetLength(0);++i)
        {
            avg+=arr[i,j];
        }
        Console.WriteLine($"{avg/arr.GetLength(0):f2}");
    } 
}
int [,] newmatrix=NewDualArray(5,5,0,10);
PrintDualArray(newmatrix);
AverageValueColumns(newmatrix);