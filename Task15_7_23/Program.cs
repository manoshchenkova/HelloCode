// 15. Дано число. Проверить кратно ли оно 7 и 23

Console.Write("Our number is ");
 int Number = new Random().Next(1, 999);
 //int Number = 161;
 Console.WriteLine(Number);

int FirstDivider = 7;
int SecondDivider = 23;

if (Number%FirstDivider == 0 && Number%SecondDivider == 0)
{
    Console.WriteLine($"Число {Number} кратно {FirstDivider} и {SecondDivider}");
}
else 
{
    Console.WriteLine($"Число {Number} НЕ кратно {FirstDivider} и {SecondDivider}");
}