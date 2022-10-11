Console.WriteLine("Введите номер дня недели");
int day;
try
{
    day = int.Parse(Console.ReadLine());
    if (day > 0 && day < 8)
    {
        if (day < 6) { Console.WriteLine("Рабочий день"); }
        else Console.WriteLine("Выходной");
    }
    else Console.WriteLine("Не день недели");
}
catch (Exception x) { Console.WriteLine(x.Message); }

Console.ReadKey();