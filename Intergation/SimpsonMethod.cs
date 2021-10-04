using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Integration
{
    public class SimpsonMethod : IIntegralFinder
    {
        const int N = 50;
        public double CalculateIntegralValue(Func<double, double> function, double startInterval, double endInterval)
        {
            if (startInterval >= endInterval)
            {
                throw new ArgumentException("Start of interval is higher than end of interval");
            }

            if (function is null)
            {
                throw new ArgumentNullException(nameof(function), "Function is null");
            }

            double increment = (endInterval - startInterval) / (2 * N);

            double integralValue = 0;
            for (int i = 0; i < N; i++)
            {
                integralValue += function(startInterval + 2 * i * increment) + 4 * function(startInterval + (2 * i + 1) * increment) + function(startInterval + (2 * i + 2) * increment);
            }

            integralValue *= increment / 3;

            return integralValue;
        }
    }
}
