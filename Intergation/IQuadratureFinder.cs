using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Integration
{
    public interface IQuadratureFinder : IIntegralFinder
    {
        protected const int N = 100;

         void CheckInputParameters(Func<double, double> function, double startInterval, double endInterval)
        {
            if (startInterval >= endInterval)
            {
                throw new ArgumentException("Start of interval is higher than end of interval");
            }

            if (function is null)
            {
                throw new ArgumentNullException(nameof(function), "Function is null");
            }
        }
    }
}
