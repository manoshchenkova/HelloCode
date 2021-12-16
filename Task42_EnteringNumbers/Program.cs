//42. Определить сколько чисел больше 0 введено с клавиатуры



// Console.WriteLine("Number 2 is");
// int Number2 = int.Parse(Console.ReadLine());

// Console.WriteLine("Number 3 is");
// int Number3 = int.Parse(Console.ReadLine());

// Console.WriteLine("Number 4 is");
// int Number4 = int.Parse(Console.ReadLine());

// Console.WriteLine("Number 5 is");
// int Number5 = int.Parse(Console.ReadLine());

// int[] UserNumbers = new int [Number1, Number2, Number3, Number4, Number5];

Console.Clear();
Console.WriteLine("How many numbers do you want to enter?");
int UserNumber = int.Parse(Console.ReadLine());

int count = 0;

for(int i = 1; i <= UserNumber; i++)
{
    Console.Write($"Number {i} is ");
    int Number = int.Parse(Console.ReadLine());
    
    if(Number>0)
        count++;
}
Console.WriteLine($"{count} positive numbers entered");
