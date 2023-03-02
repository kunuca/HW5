// Написать программу копирования массива
void FillArray(int[] numbers)
{
    int length=numbers.Length;
    for (int i = 0; i < length; i++)
    {
        numbers[i]=new Random().Next(1,100);
    }
}

void FillCopy(int[] numbers,int[] copy)
{
    int len=numbers.Length;
    for (int i = 0; i < len; i++)
    {
        copy[i]=numbers[i];
    }
}

void PrintIn(int[] mass)
{
    int l=mass.Length;
    for (int i = 0; i < l; i++)
    {
        Console.Write($"\t{mass[i]}");
    }
    
}

int[] array=new int[5];
FillArray(array);
PrintIn(array);
Console.WriteLine();
int[] dubl=new int[5];
FillCopy(array, dubl);
PrintIn(dubl);