using FinancialForecasting;
using System;

class Program
{
    static void Main()
    {
        double initial = 10000; // Starting amount
        double rate = 0.08;     // 8% annual growth
        int years = 5;

        double result = Forecast.ForecastFutureValue(initial, rate, years);
        Console.WriteLine($"Future value after {years} years: ₹{result:F2}");
    }
}
