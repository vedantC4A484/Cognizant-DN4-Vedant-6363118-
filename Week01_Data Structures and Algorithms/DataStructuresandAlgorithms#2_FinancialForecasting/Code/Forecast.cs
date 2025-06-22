using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancialForecasting
{
    public static class Forecast
    {
        public static double ForecastFutureValue(double presentValue,double growthRate,int years)
        {
            if (years == 0) return presentValue;
            double newValue = presentValue * (1 + growthRate);
            return ForecastFutureValue(newValue,growthRate, years-1);
        }

        public static double ForecastFutureValueIterative(double presentValue, double growthRate, int years)
        {
            for (int i = 0; i < years; i++)
            {
                presentValue *= (1 + growthRate);
            }
            return presentValue;
        }

    }
}
