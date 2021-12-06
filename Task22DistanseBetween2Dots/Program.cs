// 22. Найти расстояние между точками в пространстве 2D/3D

// Формулы вычисления расстояния между двумя точками:
// Формула вычисления расстояния между двумя точками A(xa, ya) и B(xb, yb) на плоскости:
// AB = √(xb - xa)2 + (yb - ya)2
// Формула вычисления расстояния между двумя точками A(xa, ya, za) и B(xb, yb, zb) в пространстве:
// AB = √(xb - xa)2 + (yb - ya)2 + (zb - za)2

/* Console.WriteLine("Enter xa coordinate: ");
int xa = int.Parse(Console.ReadLine());

Console.WriteLine("Enter ya coordinate: ");
int ya = int.Parse(Console.ReadLine());

Console.WriteLine("Enter xb coordinate: ");
int xb = int.Parse(Console.ReadLine());

Console.WriteLine("Enter yb coordinate: ");
int yb = int.Parse(Console.ReadLine());


double Distance2D = Math.Sqrt(Math.Pow((xb-xa),2) + Math.Pow((yb - ya),2));
Console.WriteLine($"2D distance between the dots is {Distance2D}");
*/

Console.WriteLine("Enter xa coordinate: ");
int xa = int.Parse(Console.ReadLine());

Console.WriteLine("Enter ya coordinate: ");
int ya = int.Parse(Console.ReadLine());

Console.WriteLine("Enter za coordinate: ");
int za = int.Parse(Console.ReadLine());

Console.WriteLine("Enter xb coordinate: ");
int xb = int.Parse(Console.ReadLine());

Console.WriteLine("Enter yb coordinate: ");
int yb = int.Parse(Console.ReadLine());

Console.WriteLine("Enter zb coordinate: ");
int zb = int.Parse(Console.ReadLine());

double Distance3D = Math.Sqrt(Math.Pow((xb-xa),2) + Math.Pow((yb - ya),2) + Math.Pow((zb - za),2));
Console.WriteLine($"3D distance between the dots is {Distance3D}");