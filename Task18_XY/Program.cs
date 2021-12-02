// 18. Проверить истинность утверждения ¬(X ⋁ Y) = ¬X ⋀ ¬Y
/*Console.Clear();

bool X = true;
bool Y = true;

if (!(X || Y) == (!X && !Y))
{
    Console.WriteLine("Выражение истинно");
}
else
{
    Console.WriteLine("Выражение ложно");
}
*/

Console.Clear();

bool TrueFalse(bool X, bool Y)
{
    return (!(X || Y) == (!X && !Y));
}

bool [] X = {true, false};
bool [] Y = {true, false};

bool result = true;
for(int i = 0; i<X.Length; i++)
{
    for(int j = 0; j<X.Length; j++)
    {
        Console.WriteLine($"For {X[i]} and {Y[j]} ¬(X ⋁ Y) = ¬X ⋀ ¬Y is  {TrueFalse(X[i], Y[j])}");
        if(!TrueFalse(X[i], Y[j]))
        {
            Console.WriteLine("Statement ¬(X ⋁ Y) = ¬X ⋀ ¬Y is false");
            result = false;
        }
    }
}
if (result)

{
    Console.WriteLine("Statement ¬(X ⋁ Y) = ¬X ⋀ ¬Y is proven");
}
else 
{
    Console.WriteLine("Statement ¬(X ⋁ Y) = ¬X ⋀ ¬Y is not proven");
}
