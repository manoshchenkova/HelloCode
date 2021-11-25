// Показать вторую цифру трёхзначного числа

int N = new Random().Next(100,999);
Console.WriteLine("Our number is - {0}", N);

N = N%100;
N = (N/10);

Console.WriteLine("Middle number is {0}", N);