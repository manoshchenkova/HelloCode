// Выяснить является ли число чётным

Console.WriteLine("Enter your number");
int Number = int.Parse(Console.ReadLine());
if (Number % 2 == 0)
    {
        Console.WriteLine("This is an even number");
    }
    else 
    {
        Console.WriteLine("This is NOT an even number");
    }
