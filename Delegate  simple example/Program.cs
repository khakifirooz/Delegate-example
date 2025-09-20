
int[] number = { 23, 40, 50, 55, 78, 88 };
MathDelegate del = IsEven;

var result = FilterArrey(number, del);

foreach (var item in result)
{
    Console.WriteLine(item);
}
Console.ReadKey();

static bool IsEven(int number)
{
    return number % 2 == 0;
}
static bool IsOdd(int number)
{
    return number % 2 == 1;
}

static List<int> FilterArrey(int[] array , MathDelegate predicate)
{
    List<int> result = new List<int>();
    foreach (var item in array)
    {
        if (predicate(item))
        {
            result.Add(item);
        }
    }
    return result;
}

public delegate bool MathDelegate(int number);