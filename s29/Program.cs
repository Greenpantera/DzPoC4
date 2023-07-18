// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
int[]MakeNewBinaryArray(int size)
{
    int[]array=new int[size];
    for(int i=0;i<size;i++)
    {
        array[i] = new Random().Next();   
     }
     return array;
}

int[]array = MakeNewBinaryArray(8);
Console.WriteLine(string.Join(",", array)); 
