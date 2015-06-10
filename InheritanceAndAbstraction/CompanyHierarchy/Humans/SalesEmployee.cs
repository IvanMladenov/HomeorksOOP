using System.Collections.Generic;
using CompanyHierarchy.Props;

namespace CompanyHierarchy.Humans
{
    class SalesEmployee:RegularEmployee
    {
        public SalesEmployee(string id, string firstName, string lastName, decimal salary, string department)
            :base(id,firstName,lastName,salary,department)
        {
            this.Sales = new List<Sales>();
        }

        public List<Sales> Sales { get; set; }
    }
}
