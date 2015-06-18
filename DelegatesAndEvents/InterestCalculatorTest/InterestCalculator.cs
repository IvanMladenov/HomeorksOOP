namespace InterestCalculatorTest
{
    public delegate decimal InterestCalculation(decimal sum, decimal interestRate, int years);

    public class InterestCalculator
    {
        private readonly InterestCalculation method;

        public InterestCalculator(decimal sum, decimal interestRate, int years, InterestCalculation method)
        {
            this.InterestRate = interestRate;
            this.Sum = sum;
            this.Years = years;
            this.method = method;
        }

        public decimal Sum { get; set; }

        public decimal InterestRate { get; set; }

        public int Years { get; set; }

        public decimal InterestCalculated
        {
            get
            {
                return this.method(this.Sum, this.InterestRate, this.Years);
            }
        }
    }
}