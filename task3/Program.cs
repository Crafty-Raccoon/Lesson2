Console.WriteLine("Введите число");
ConsoleKeyInfo inpKey = new
ConsoleKeyInfo();
int k = 0;
bool flag = true;
int res = 0;
while (flag)
{
    inpKey = Console.ReadKey();
    if (inpKey.Key != ConsoleKey.Enter)
    {
        k++;
        if (k == 3) ;
        {
            res = inpKey.KeyChar;
            res = int.Parse(Char.ConvertFromUtf32(res));
        }
    }
    else { flag = !flag; }
}
Console.WriteLine("");
if (k < 3)
{ Console.WriteLine("Оно не трехзначное"); }
else
{ Console.WriteLine(res); }
Console.ReadKey(); 
