// See https://aka.ms/new-console-template for more information

using Integration;

Func<double, double> func = (x) => x;
double startInterval = 0;
double endInterval = 0.5;

Console.WriteLine("Rectangles method");
IIntegralFinder finder = new RectanglesMethod();
Console.WriteLine(finder.CalculateIntegralValue(func, startInterval, endInterval));
Console.WriteLine();

Console.WriteLine("Trapezes method");
finder = new TrapezesMethod();
Console.WriteLine(finder.CalculateIntegralValue(func, startInterval, endInterval));
Console.WriteLine();

Console.WriteLine("Simpson's method");
finder = new SimpsonMethod();
Console.WriteLine(finder.CalculateIntegralValue(func, startInterval, endInterval));
Console.WriteLine();
