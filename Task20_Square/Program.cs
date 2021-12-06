//20. Задать номер четверти, показать диапазоны для возможных координат

String[] Quaters = {"First Quater is X>0 Y >0", "Second Quater is X<0 Y>0", "Third Quater is X<0 Y<0", "Forth quater is X>0 Y<0"};

Console.WriteLine("Please enter your quater number: ");
int Quater = int.Parse(Console.ReadLine());

Console.Clear();

if(Quater>0 && Quater<=4)
{
Console.WriteLine(Quaters[Quater-1]);
}
else 
{
    Console.WriteLine("There are only 4 quaters, please enter valid number");
}
