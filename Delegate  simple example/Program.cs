Delegate:

int[] Number = { 23, 40, 50, 55, 78, 88 };

//MathDelegate del = IsEven;
// Lambda expression :
MathDelegate even = number => number % 2 == 0;

var result = FilterArrey(Number, even);

foreach (var item in result)
{
    Console.WriteLine(item);
}
Console.ReadKey();


static List<int> FilterArrey(int[] array, MathDelegate predicate)
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

//-------------------------
// Generic Delegate:


//public delegate T MyDelegate<T>(T p1, T p2);

public delegate bool MathDelegate(int number);