// See https://aka.ms/new-console-template for more information

using Integration;

Func<double, double> func = (x) => x / (2 * x + 1);
double startInterval = 0.2;
double endInterval = 1;

Console.WriteLine("Rectangles method");
IIntegralFinder finder = new RectanglesMethod();
finder.countOfPartitions = 6;
Console.WriteLine("{0:##0.######}",finder.CalculateIntegralValue(func, startInterval, endInterval));
Console.WriteLine();

Console.WriteLine("Trapezes method");
finder = new TrapezesMethod();
finder.countOfPartitions = 8;
Console.WriteLine("{0:##0.######}", finder.CalculateIntegralValue(func, startInterval, endInterval));
Console.WriteLine();

Console.WriteLine("Simpson's method");
finder = new SimpsonMethod();
finder.countOfPartitions = 2;
Console.WriteLine("{0:##0.######}", finder.CalculateIntegralValue(func, startInterval, endInterval));
Console.WriteLine();

Console.WriteLine("Gauss's method");
finder = new GaussMethod();
Console.WriteLine("{0:##0.######}", finder.CalculateIntegralValue(func, startInterval, endInterval));
Console.WriteLine();
