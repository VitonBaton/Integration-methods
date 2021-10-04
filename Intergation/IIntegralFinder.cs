﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Integration
{
    public interface IIntegralFinder
    {
        public double CalculateIntegralValue(Func<double, double> function, double startInterval, double endInterval);
    }
}
