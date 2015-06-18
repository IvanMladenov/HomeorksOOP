namespace InterestCalculatorTest
{
    using System;
    using System.Diagnostics.CodeAnalysis;

    internal class InterestCalculatorTest
    {
        private const int MonthsInterestCompounded = 12;

        private static void Main()
        {
            InterestCalculator accountFirst = new InterestCalculator(500, 0.056m, 10, GetCompoundInterest);
            InterestCalculator accountSecond = new InterestCalculator(2500, 0.072m, 15, GetSimpleInterest);

            Console.WriteLine(accountFirst.InterestCalculated);
            Console.WriteLine(accountSecond.InterestCalculated);
        }

        private static decimal GetSimpleInterest(decimal sum, decimal interest, int years)
        {
            var balance = sum * (1 + interest * years);
            return decimal.Round(balance, 4);
        }

        private static decimal GetCompoundInterest(decimal sum, decimal interest, int years)
        {
            decimal result = sum
                             * (decimal)
                               Math.Pow(
                                   (double)(1 + interest / MonthsInterestCompounded), 
                                   years * MonthsInterestCompounded);
            return decimal.Round(result, 4);
        }
    }
}