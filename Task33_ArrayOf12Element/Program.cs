// 33. Задать массив из 12 элементов, заполненных числами из [0,9]. Найти сумму положительных/отрицательных элементов массива

Console.Clear();

int[] Array = new int[12];
int SumPositive = 0;
int SumNegative = 0;

void FillArray(int[] Array1)
{
    for(int i = 0; i < Array1.Length; i++)
    {
        Array1[i] = new Random().Next(-9,9);
        Console.Write(Array1[i] + " ");
    }
}

void Sum(int[] Array2)
{
    for(int j = 0; j < Array.Length; j++)
{
    if(Array[j]>0) SumPositive += Array[j];
    else SumNegative += Array[j];
}
}

FillArray(Array);
Sum(Array);
Console.WriteLine();

// int SumPositive = 0;
// int SumNegative = 0;

// for(int j = 0; j < Array.Length; j++)
// {
//     if(Array[j]>0) SumPositive += Array[j];
//     else SumNegative += Array[j];
// }

Console.WriteLine($"Sum of Positive numbers is {SumPositive}");
Console.WriteLine($"Sum of Negative numbers is {SumNegative}");
