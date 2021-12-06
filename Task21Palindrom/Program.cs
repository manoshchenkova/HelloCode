//21. Программа проверяет пятизначное число на палиндромом.
Console.WriteLine("Please enter your 5-digit number: ");
int Palindrom = int.Parse(Console.ReadLine());

int[] array = new int[5];

for(int i = 4; i >= 0; i--)
{
    array[i] = Palindrom % 10;
    Palindrom = Palindrom / 10;

// Console.Write(array[i] + " ");
}

Console.Clear();

int j = 0; 

while (j <2)
{
    if (array [j] != array [4-j])
    {
        Console.WriteLine("This number is NOT a palindrome");
    return;
    }
    j++;
}
   Console.WriteLine("This number is a palindrome");