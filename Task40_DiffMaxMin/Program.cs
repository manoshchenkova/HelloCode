// 40. В Указанном массиве вещественных чисел найдите разницу между максимальным и минимальным элементом

Console.Clear();

double[] Array = new double[10];


void FillArray(double[] Array1)
{
    for (int i = 0; i < Array1.Length; i++)
    {
        Array1[i] = new Random().NextDouble() + new Random().Next(-100, 100);
        Console.Write(Array1[i] + " ");
    }
    Console.WriteLine();
}

FillArray(Array);

double maxElement = Array[0];
double minElement = Array[0];

for (int i = 0; i < Array.Length; i++)
{
    if (Array[i] > maxElement) 
        maxElement = Array[i];
    else if (Array[i] < minElement)
        minElement = Array[i];
}
Console.WriteLine($"Max Element is {maxElement}");
Console.WriteLine($"Min Element is {minElement}");

double diffOfMaxMin = maxElement - minElement;
Console.WriteLine($"Difference between Max and Min is {diffOfMaxMin}");