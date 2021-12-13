//50. В двумерном массиве n×k заменить четные элементы на противоположные
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
            DoubleArray[i,j]= new Random().Next(-10,10);
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

// void MirrorDoubleArray(int[,] DoubleArray)
// {
//     for(int i = 0; i < DoubleArray.GetLength(0); i++)
//     {
//         for(int j = 0; j < DoubleArray.GetLength(1); j++)
//         {
//             if(DoubleArray[i,j] % 2 == 0 )
//                 DoubleArray[i,j] = DoubleArray[i,j]*-1;
            
//             Console.Write(DoubleArray[i,j] + " ");
//         }
//         Console.WriteLine();
//     }
// }

FillDoubleArray(doubleArray);
PrintDoubleArray(doubleArray);
Console.WriteLine();

for(int i=0; i < doubleArray.GetLength(0); i++)
{
    for(int j=0; j < doubleArray.GetLength(1); j++)
        {
            if(doubleArray[i,j] % 2 == 0 )
                doubleArray[i,j] = doubleArray[i,j]*-1;
            
            Console.Write(doubleArray[i,j] + " ");
        }
        Console.WriteLine();
        
}

// FillDoubleArray(doubleArray);
// PrintDoubleArray(doubleArray);
// Console.WriteLine();
// MirrorDoubleArray(doubleArray);