Random rnd = new Random();
int a = rnd.Next(100, 999);
Console.WriteLine(a);
int b = a / 100;
b = b * 10 + a % 10;
Console.WriteLine(b);

Console.ReadKey();