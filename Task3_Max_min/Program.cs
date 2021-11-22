Console.WriteLine("Enter number 1");
int NumberA = int.Parse(Console.ReadLine());
Console.WriteLine("Enter number 2");
int NumberB = int.Parse(Console.ReadLine());
if (NumberA>NumberB)
{
    Console.WriteLine("Max number is - {0}", NumberA);
    Console.WriteLine("Min number is  - {0}", NumberB);
}
else 
{
    Console.WriteLine("Max number is  - {0}", NumberB);
    Console.WriteLine("Min number is - {0}", NumberA);
}
