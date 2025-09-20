
Func<int, int, int> del = Max;
Console.WriteLine($"Max is : {del(10,20)}");

Func<string> del2 = Display;
Console.WriteLine($"result is {del2()}");

Console.ReadKey();
static int Max(int n1, int n2)
{
    return Math.Max(n1, n2);
}

static string Display()
{
    return "hello";
}
