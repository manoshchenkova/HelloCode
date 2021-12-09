// 31. Задать массив из 8 элементов и вывести их на экран 

Console.Clear();

int[] Array = new int[8];

void FillArray(int[] Array1)
{
    int i = 0;
    while (i < Array1.Length)
    {
        Array1[i] = new Random().Next(1,10);
        i++;
    }
}

void PrintArray(int[] Array2)
{
    int j = 0;
    while(j<Array2.Length)
        {
            Console.Write($" {Array2[j]} ");
            j++;
        }
}
PrintArray(Array);
Console.WriteLine();
FillArray(Array);
PrintArray(Array);