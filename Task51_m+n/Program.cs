// 51. Задать двумерный массив следующим правилом: Aₘₙ = m+n

Console.Clear();

Console.WriteLine("Please enter number of rows");
int rows = int.Parse(Console.ReadLine());

Console.WriteLine("Please enter number of columns");
int columns = int.Parse(Console.ReadLine());

int[,] doubleArray = new int[rows, columns];

void FillDoubleArray(int[,] DoubleArray)
{
    for(int i = 0; i < DoubleArray.GetLength(0); i++)
    {
        for(int j = 0; j < DoubleArray.GetLength(1); j++)
        {
            DoubleArray[i,j]= i + j;
        }
    }
}

void PrintDoubleArray(int[,] DoubleArray)
{
    for(int i = 0; i < DoubleArray.GetLength(0); i++)
    {
        for(int j = 0; j < DoubleArray.GetLength(1); j++)
        {
            Console.Write(DoubleArray[i,j] + " ");
        }
        Console.WriteLine();
    }
}

FillDoubleArray(doubleArray);
PrintDoubleArray(doubleArray);