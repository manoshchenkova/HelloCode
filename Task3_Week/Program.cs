string [] array = {"Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday"};
Console.WriteLine("Enter day number");

int DayOfWeek = int.Parse(Console.ReadLine());

if (DayOfWeek > 7 || DayOfWeek < 1)
{
Console.WriteLine("There are 7 days a week");
}
else
{
Console.WriteLine(array [DayOfWeek-1]);
}