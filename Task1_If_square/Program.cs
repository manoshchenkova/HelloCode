Console.WriteLine("Enter number 1");
int NumberA = int.Parse(Console.ReadLine());
Console.WriteLine("Enter number 2");
int NumberB = int.Parse(Console.ReadLine());
if (NumberA*NumberA == NumberB)
{
Console.WriteLine("Yes, number 2 is a square of number 1");
}
else 
{
    Console.WriteLine("No, number 2 is NOT a square of number 1");
}