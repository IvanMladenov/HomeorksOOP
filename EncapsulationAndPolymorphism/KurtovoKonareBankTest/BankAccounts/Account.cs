using System;
using KurtovoKonareBankTest.Interfaces;

namespace KurtovoKonareBankTest.BankAccounts
{
    abstract class Account:IAccount
    {
        //private decimal balance;
        private decimal interestRate;
        private ICostomer costomer;

        public Account(decimal balance, decimal monthlyInterestRate, ICostomer costomer)
        {
            this.Balance = balance;
            this.InterestRate = monthlyInterestRate;
            this.Costomer = costomer;
        }

        public ICostomer Costomer
        {
            get { return this.costomer; }
            private set
            {
                if (value == null)
                {
                    throw new NullReferenceException("Object cant be null.");
                }
                this.costomer = value;
            }
        }
       
        public decimal Balance { get; private set; }

        public decimal InterestRate
        {
            get { return this.interestRate; }
            private set
            {
                if (value < 0)
                {
                    throw new IndexOutOfRangeException("Rate cant be less than 0.");
                }
                this.interestRate = value;
            }
        }


        public virtual decimal MontylyInterestRateCalc(int months)
        {
            decimal interestMoney = this.Balance*(1 + this.InterestRate*months);
            return interestMoney;
        }
        
        public void AddMoney(decimal moneyToAdd)
        {
            this.Balance += moneyToAdd;
        }

        public override string ToString()
        {
            return  string.Format("{0}\nBalance: {1}\nInterest Rate: {2}", this.Costomer, this.Balance, this.InterestRate);
        }
    }
}
