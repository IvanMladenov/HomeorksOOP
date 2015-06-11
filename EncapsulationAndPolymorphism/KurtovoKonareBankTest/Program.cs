using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using KurtovoKonareBankTest.BankAccounts;
using KurtovoKonareBankTest.Classes;
using KurtovoKonareBankTest.Interfaces;

namespace KurtovoKonareBankTest
{
    class Program
    {
        static void Main(string[] args)
        {
            ICostomer costomerIndiidual=new Costomer("Pesho",CostomerType.Individual);
            ICostomer costomerCompany=new Costomer("Gosho",CostomerType.Company);

            IAccount firstDeposit=new DepositAccounts(999, 1.25m,costomerIndiidual);
            IAccount seconDeposit= new DepositAccounts(1557.7m,3,costomerCompany);

            IAccount firstLoan=new LoanAccouonts(15000,2.75m,costomerIndiidual);
            IAccount secondLoan = new LoanAccouonts(151.20m, 1.75m, costomerCompany);

            IAccount firtsMortgage=new MortgageAccounts(11275,0.27m,costomerIndiidual);
            IAccount secondMorgage=new MortgageAccounts(95.2785m,5.5m,costomerCompany);

            Console.WriteLine(firstDeposit);
            Console.WriteLine();

            List<IAccount>accounts=new List<IAccount>();
            accounts.Add(firstDeposit);
            accounts.Add(seconDeposit);
            accounts.Add(firstLoan);
            accounts.Add(secondLoan);
            accounts.Add(firtsMortgage);
            accounts.Add(secondMorgage);

            foreach (var account in accounts)
            {
                Console.WriteLine("{0}-->Interest Rate: {1}\n{2}",account.Costomer,account.MontylyInterestRateCalc(5),account.GetType());
            }
            Console.WriteLine("\n\n");

            foreach (var account in accounts)
            {
                Console.WriteLine("{0}-->Interest Rate: {1}\n{2}", account.Costomer, account.MontylyInterestRateCalc(15), account.GetType());
            }
        }
    }
}
