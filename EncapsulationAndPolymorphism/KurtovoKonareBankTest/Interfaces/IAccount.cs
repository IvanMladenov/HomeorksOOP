using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KurtovoKonareBankTest.Interfaces
{
    interface IAccount
    {
        //Properties
        ICostomer Costomer { get; }

        decimal Balance { get;}

        decimal InterestRate { get; }      

        //Methods
        decimal MontylyInterestRateCalc(int months);

        void AddMoney(decimal moneyToAdd);
    }
}
