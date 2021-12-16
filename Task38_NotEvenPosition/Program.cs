// 38. Найти сумму чисел одномерного массива стоящих на нечетной позиции

void FillArray(int[] Array1)
{
    for(int i = 0; i < Array1.Length; i++)
    {
        Array1[i] = new Random().Next(1,10);
        Console.Write(Array1[i] + " ");
    }
}

void SumOfOddIndexes(int[] Array2)
{
    int Sum = 0;
    for(int j = 0; j < Array2.Length; j++)
    {
        if (j %2 == 1)
        Sum = Sum + Array2[j];
    }
    Console.WriteLine($"The sum of numbers in odd indexes in this array is {Sum}");
}

Console.Clear();

int[] Array = new int[10];

FillArray(Array);
Console.WriteLine();
SumOfOddIndexes(Array);
