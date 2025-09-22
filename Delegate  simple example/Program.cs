
//using static rectangle;

//Func<int, int, int> del = Max;
//Console.WriteLine($"Max is : {del(10, 20)}");

//Func<string> del2 = Display;
//Console.WriteLine($"result is {del2()}");

//Action<int, int> del3 = Sum;
//del3(20, 50);
//Console.ReadKey();

//static void Sum(int x, int y)
//{
//    Console.WriteLine(x+y);
//}
//static int Max(int n1, int n2)
//{
//    return Math.Max(n1, n2);
//}

//static string Display()
//{
//    return "hello";
//}
//---------------------------------------------------------


// creating object of class 
// "rectangle", named as "rect"
using static rectangle;

rectangle rect = new rectangle();

// these two lines are normal calling
// of that two methods
// rect.area(6.3, 4.2);
// rect.perimeter(6.3, 4.2);

// creating delegate object, name as "rectdele"
// and pass the method as parameter by 
// class object "rect"
rectDelegate rectdele = new rectDelegate(rect.area);

// also can be written as 
// rectDelegate rectdele = rect.area;

// call 2nd method "perimeter"
// Multicasting
rectdele += rect.perimeter;

// pass the values in two method 
// by using "Invoke" method
rectdele.Invoke(6.3, 4.2);
Console.WriteLine();

// call the methods with 
// different values
rectdele.Invoke(16.3, 10.3);

Console.ReadKey();
class rectangle
{

    // declaring delegate
    public delegate void rectDelegate(double height,
                                      double width);

    // "area" method
    public void area(double height, double width)
    {
        Console.WriteLine("Area is: {0}", (width * height));
    }

    // "perimeter" method
    public void perimeter(double height, double width)
    {
        Console.WriteLine("Perimeter is: {0} ", 2 * (width + height));
    }
}

