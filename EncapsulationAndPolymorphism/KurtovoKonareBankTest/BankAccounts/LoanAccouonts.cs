using KurtovoKonareBankTest.Interfaces;

namespace KurtovoKonareBankTest.BankAccounts
{
    class LoanAccouonts:Account
    {
        public LoanAccouonts(decimal balance, decimal monthlyInterestRate, ICostomer costomer) : base(balance, monthlyInterestRate, costomer)
        {
        }

        public override decimal MontylyInterestRateCalc(int months)
        {
            int monthsReduced = months;
            if (this.Costomer.CostomerType == CostomerType.Company)
            {
                monthsReduced -= 2;
            }
            else if(this.Costomer.CostomerType==CostomerType.Individual)
            {
                monthsReduced -= 3;
            }
            return base.MontylyInterestRateCalc(monthsReduced);
        }
    }
}
