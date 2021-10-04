
namespace Integration;
public class RectanglesMethod : IIntegralFinder
{
    public int countOfPartitions { get; set; } = 100;
    public double CalculateIntegralValue(Func<double, double> function, double startInterval, double endInterval)
    {
        if (startInterval >= endInterval)
        {
            throw new ArgumentException("Start of interval is higher than end of interval");
        }

        if (function is null)
        {
            throw new ArgumentNullException(nameof(function),"Function is null");
        }

        double increment = (endInterval - startInterval) / countOfPartitions;

        double integralValue = 0;
        for (int i = 0; i < countOfPartitions; i++)
        {
            integralValue += function(startInterval + i * increment + increment / 2);
        }

        integralValue *= increment;

        return integralValue;
    }
}
