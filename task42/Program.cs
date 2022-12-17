int ReadInt(string messages)
{
    Console.WriteLine(messages);
    return Convert.ToInt32(Console.ReadLine());
}
int num =ReadInt("Введите число число :");
int numd= num;
int i=0;
for (;numd!=0 ;i++)
{
   numd=numd/2;
}
int[] arr=new int[i];
for (;num!=0;i--)
{
    arr[i-1]=num%2;
    num=num/2;
}
Console.WriteLine(string.Join("",arr));

