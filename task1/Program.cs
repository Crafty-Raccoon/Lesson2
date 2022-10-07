Console.WriteLine("Введите трёхзначное число");
int a;
try
{
     a = int.Parse(Console.ReadLine());
    a = a / 10;
    a= a % 10;
    //Math.DivRem(a, 10, out a);
    Console.WriteLine(a.ToString());
}
catch (Exception x ) { Console.WriteLine(x.Message); }

Console.ReadKey();
