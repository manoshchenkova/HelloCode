// Задать массив, заполнить случайными положительными трёхзначными числами. Показать количество нечетных\четных чисел

void FillArray(int[] Array1)
{
    for(int i = 0; i < Array1.Length; i++)
    {
        Array1[i] = new Random().Next(100,999);
        Console.Write(Array1[i] + " ");
    }
}

void CountEven(int[] Array2)
{
    int countEven = 0;
    int countNotEven = 0;
    for(int j = 0; j < Array2.Length; j++)
{
    if(Array2[j] % 2 ==0 ) countEven ++;
    else countNotEven ++;
}
        Console.WriteLine();
        Console.WriteLine($"The amount of Even numbers is {countEven}");
        Console.WriteLine($"The amount of non-Even numbers is {countNotEven}");
}
Console.Clear();


int[] Array = new int[12];

FillArray(Array);
CountEven(Array);
Console.WriteLine();

//Console.WriteLine($"The amount of Even numbers is {countEven}");
//Console.WriteLine($"The amount of non-Even numbers is {countNotEven}");