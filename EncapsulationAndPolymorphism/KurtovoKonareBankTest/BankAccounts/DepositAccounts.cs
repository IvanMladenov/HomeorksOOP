
using KurtovoKonareBankTest.Interfaces;

namespace KurtovoKonareBankTest.BankAccounts
{
    class DepositAccounts:Account
    {
        public DepositAccounts(decimal balance, decimal monthlyInterestRate, ICostomer costomer) : base(balance, monthlyInterestRate, costomer)
        {
        }

        public override decimal MontylyInterestRateCalc(int months)
        {
            if (this.Balance > 0 && this.Balance < 100)
            {
                return 0;
            }
            return base.MontylyInterestRateCalc(months);
        }
    }
}
