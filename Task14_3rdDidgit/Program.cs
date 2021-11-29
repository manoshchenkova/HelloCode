//14. Найти третью цифру числа или сообщить, что её нет

Console.Write("Our number is ");
 int N = new Random().Next(1, 99999999);
 Console.WriteLine(N);

 if (N>99)
     {
      while (N>1000)
      {
          N = N / 10;
      }
      Console.WriteLine($"Third digit is {N%10}");
     }
else 
 {
     Console.WriteLine("There's no 3rd digit in this number");
 }
