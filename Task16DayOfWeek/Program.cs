//16. Дано число обозначающее день недели. Выяснить является номер дня недели выходным 

string [] array = {"Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday"};
Console.WriteLine("Enter day number");

int DayOfWeek = int.Parse(Console.ReadLine());

if (DayOfWeek < 1 || DayOfWeek > 7)
    {
        Console.WriteLine("There are 7 days a week");
    }
    if (DayOfWeek == 6 || DayOfWeek == 7)
        {
             Console.WriteLine($"{array[DayOfWeek-1]} is a weekend");
        }
    else
    {
        Console.WriteLine($"{array[DayOfWeek-1]} is NOT a weekend");
    }
