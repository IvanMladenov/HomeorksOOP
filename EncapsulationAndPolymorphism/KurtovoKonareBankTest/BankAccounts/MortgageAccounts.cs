using KurtovoKonareBankTest.Interfaces;

namespace KurtovoKonareBankTest.BankAccounts
{
    class MortgageAccounts:Account
    {
        public MortgageAccounts(decimal balance, decimal monthlyInterestRate, ICostomer costomer) : base(balance, monthlyInterestRate, costomer)
        {
        }

        public override decimal MontylyInterestRateCalc(int months)
        {
            decimal interest = 0;

            switch (this.Costomer.CostomerType)
            {
                    case CostomerType.Company:
                    if (months <= 12)
                    {
                        interest = base.MontylyInterestRateCalc(months)/2;
                    }
                    else
                    {
                        interest = base.MontylyInterestRateCalc(12) / 2 + base.MontylyInterestRateCalc(months-12);
                    }
                    break;

                    case CostomerType.Individual:
                    if (months <= 6)
                    {
                        interest = 0;
                    }
                    else
                    {
                        interest = base.MontylyInterestRateCalc(months - 6);
                    }
                    break;
            }
            return interest;
        }
    }
}
