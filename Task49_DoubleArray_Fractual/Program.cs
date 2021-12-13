// 49. Показать двумерный массив размером m×n заполненный вещественными числами

Console.Clear();

Console.WriteLine("Please enter number of rows");
int rows = int.Parse(Console.ReadLine());

Console.WriteLine("Please enter number of columns");
int columns = int.Parse(Console.ReadLine());

double[,] doubleArray = new double[rows, columns];

void FillDoubleArray(double[,] DoubleArray)
{
    for(int i = 0; i < DoubleArray.GetLength(0); i++)
    {
        for(int j = 0; j < DoubleArray.GetLength(1); j++)
        {
            DoubleArray[i,j]= new Random().Next(1,10) + new Random().NextDouble();
        }
    }
}

void PrintDoubleArray(double[,] DoubleArray)
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