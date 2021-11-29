// Дано число из отрезка [10, 99]. Показать наибольшую цифру числа

int N = new Random().Next(10,99);
Console.WriteLine("Our number is - {0}", N);

int N1 = N%10;
int N2 = N/10;
if (N1 > N2)
    {
        Console.WriteLine(N1);
    }
    else
    {
        Console.WriteLine(N2);
    }