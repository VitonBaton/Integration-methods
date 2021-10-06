using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Integration
{
    public class GaussMethod : IIntegralFinder
    {
        public int countOfPartitions
        {   get { return 5; }
            set { countOfPartitions = 5; }
        }

        List<double> x = new List<double>(5);
        List<double> c = new List<double>(5);


        public GaussMethod()
        {
            x.Add(-0.9061798);
            x.Add(-0.538469);
            x.Add(0);
            x.Add(-x[1]);
            x.Add(-x[0]);

            c.Add(0.2369268851);
            c.Add(0.47862867);
            c.Add(0.568888889);
            c.Add(c[1]);
            c.Add(c[0]);
        }

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

            var a = (endInterval - startInterval) / 2;
            var b = (endInterval + startInterval) / 2;

            double integralValue = 0;

            for (int i = 0; i < countOfPartitions; i++)
            {
                integralValue += c[i] * function(a * x[i] + b);
            }

            integralValue *= a;
            return integralValue;
        }
    }
}
