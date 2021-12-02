// 17. По двум заданным числам проверять является ли одно квадратом другого
Console.Clear();

Console.WriteLine("Enter first number:");
int FirstNumber = int.Parse(Console.ReadLine());

Console.WriteLine("Enter second number:");
int SecondNumber = int.Parse(Console.ReadLine());

if (Math.Sqrt(FirstNumber) == SecondNumber)
{
    Console.WriteLine($"Число {FirstNumber} является квадратом {SecondNumber}" );
}
else
{
if (Math.Sqrt(SecondNumber) == FirstNumber)
{
    Console.WriteLine($"Число {SecondNumber} является квадратом {FirstNumber}" );
}
else
    {
    Console.WriteLine($"There are no square roots in those numbers" );
    }
}
