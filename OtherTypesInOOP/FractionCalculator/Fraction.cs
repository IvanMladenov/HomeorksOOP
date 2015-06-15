using System;
using System.Numerics;

namespace FractionCalculator
{
    using System.Globalization;

    public struct Fraction
    {
        private long nomerator;
        private long denomerator;

        public Fraction(long nomerator, long denomerator)
            : this()
        {
            this.Denomerator = denomerator;
            this.Nomerator = nomerator;
        }

        public long Nomerator
        {
            get { return this.nomerator; }
            set
            {
                
                this.nomerator = value;
            }
        }

        public long Denomerator
        {
            get { return this.denomerator; }
            set
            {
                if (value == 0)
                {
                    throw new DivideByZeroException("Denomerator cant be 0.");
                }
                
                this.denomerator = value;
            }
        }

        public double Result
        {
            get
            {
                return (double) this.Nomerator/this.Denomerator;
            }
        }

        //Methods

        public static Fraction operator +(Fraction a, Fraction b)
        {
            BigInteger newDenomerator = a.Denomerator*b.Denomerator;
            BigInteger newFractionANomerator = a.Nomerator*b.Denomerator;
            BigInteger newFractionBNomerator = b.Nomerator*a.Denomerator;

            BigInteger newFractionNomerator = newFractionANomerator + newFractionBNomerator;

            if (newDenomerator > long.MaxValue || newFractionNomerator > long.MaxValue ||
                newFractionANomerator > long.MaxValue || newFractionBNomerator > long.MaxValue)
            {
                throw new ArithmeticException("Too large numbers.");
            }

            return new Fraction((long)newFractionNomerator,(long)newDenomerator);
        }

        public static Fraction operator -(Fraction a, Fraction b)
        {
            BigInteger newDenomerator = a.Denomerator * b.Denomerator;
            BigInteger newFractionANomerator = a.Nomerator * b.Denomerator;
            BigInteger newFractionBNomerator = b.Nomerator * a.Denomerator;

            BigInteger newFractionNomerator = newFractionANomerator - newFractionBNomerator;

            if (newDenomerator > long.MaxValue || newFractionNomerator > long.MaxValue ||
                newFractionANomerator > long.MaxValue || newFractionBNomerator > long.MaxValue)
            {
                throw new ArithmeticException("Too large numbers.");
            }

            return new Fraction((long)newFractionNomerator, (long)newDenomerator);
        }

        public override string ToString()
        {
            
            return this.Result.ToString(CultureInfo.InvariantCulture);
        }

    }
}
