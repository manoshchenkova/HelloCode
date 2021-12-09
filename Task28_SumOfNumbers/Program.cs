//28. Подсчитать сумму цифр в числе

Console.Clear();
int Number = new Random().Next(1,1000);
Console.WriteLine($"Our number is {Number}");

int Sum = 0 ;
int ShortenedNumber = Number;

while (Number > 0)
{
    ShortenedNumber = Number % 10;
    Sum += ShortenedNumber;
    Number = Number/10;
}
Console.WriteLine($"Sum of digits is {Sum}");