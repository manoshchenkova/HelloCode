// Показать числа от -N до N

int PositiveNumber = new Random().Next(1,10);
Console.WriteLine(PositiveNumber);

int NegativeNumber = -PositiveNumber;

while(NegativeNumber <= PositiveNumber)
{
        Console.WriteLine(NegativeNumber);
        NegativeNumber = NegativeNumber + 1;
}

