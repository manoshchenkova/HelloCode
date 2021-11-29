//12. Удалить вторую цифру трёхзначного числа
Console.Write("Our number is ");
 int N = new Random().Next(100, 999);
 Console.WriteLine(N);

 int N1 = N/100;
 int N3 = N%10;

Console.Write(N1);
Console.Write(N3);

