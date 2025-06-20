using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        double initialValue = 1000.0;  // Starting amount
        double growthRate = 0.05;      // 5% annual growth
        int years = 5;

        Console.WriteLine("🔁 Recursive Financial Forecast");
        double result = PredictFutureValueRecursive(years, initialValue, growthRate);
        Console.WriteLine($"Future value after {years} years: {result:C}");

        Console.WriteLine("\n⚡ Optimized with Memoization");
        var memo = new Dictionary<int, double>();
        double optimizedResult = PredictFutureValueMemo(years, initialValue, growthRate, memo);
        Console.WriteLine($"Future value after {years} years (optimized): {optimizedResult:C}");
    }

    // Recursive version
    static double PredictFutureValueRecursive(int year, double initialValue, double rate)
    {
        if (year == 0)
            return initialValue;
        return PredictFutureValueRecursive(year - 1, initialValue, rate) * (1 + rate);
    }

    // Optimized with memoization
    static double PredictFutureValueMemo(int year, double initialValue, double rate, Dictionary<int, double> memo)
    {
        if (year == 0)
            return initialValue;
        if (memo.ContainsKey(year))
            return memo[year];

        double result = PredictFutureValueMemo(year - 1, initialValue, rate, memo) * (1 + rate);
        memo[year] = result;
        return result;
    }
}
