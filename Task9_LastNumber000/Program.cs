// Показать последнюю цифру трёхзначного числа
int N = new Random().Next(100,999);
Console.WriteLine("Our number is - {0}", N);

Console.WriteLine("Last number is {0}", N%10);