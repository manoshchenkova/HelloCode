// 27. Определить количество цифр в числе

Console.Clear();
double Number = new Random().Next(1,10000000);
Console.WriteLine($"Our number is {Number}");

int count = 0;

while (Number > 10)
{
    Number = Number/10;
    count++;
}
Console.WriteLine($"Amount of digits is {count+1}");