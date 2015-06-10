using CompanyHierarchy.Interfaces;

namespace CompanyHierarchy.Humans
{
    class Costomer:Pearson,ICostomer
    {
        private decimal totalMoneySpent;

        public Costomer(string id,string firstName,string lastName, decimal totalMoney):base(id,firstName,lastName)
        {
            this.TotalMoneySpent = totalMoney;
        }

        public decimal TotalMoneySpent {
            get { return this.totalMoneySpent; }
            set { this.totalMoneySpent = value; }
        }
    }
}
