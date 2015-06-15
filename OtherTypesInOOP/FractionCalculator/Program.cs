namespace FractionCalculator
{
    using System;

    internal class Program
    {
        private static void Main()
        {
            // Fraction fraction=new Fraction(5,2);

            // Console.WriteLine(fraction);

            // Fraction fractionTwo=new Fraction(4,3);

            // Fraction resultMinus = fraction - fractionTwo;
            // Fraction resultPlus = fraction + fractionTwo;

            // Console.WriteLine(resultPlus);
            // Console.WriteLine(resultMinus);

            // Console.WriteLine(resultPlus.Nomerator);
            // Console.WriteLine(resultMinus.Denomerator);
            Fraction fraction1 = new Fraction(22, 7);
            Fraction fraction2 = new Fraction(40, 4);
            Fraction result = fraction1 + fraction2;
            Console.WriteLine(result.Nomerator);
            Console.WriteLine(result.Denomerator);
            Console.WriteLine(result);
        }
    }
}