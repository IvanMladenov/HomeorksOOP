using System.Collections.Generic;

namespace CompanyHierarchy.Humans
{
    class Manager:Employee
    {
        public Manager(string id, string firstName, string lastName, decimal salary, string department, List<RegularEmployee> employees)
            :base(id,firstName,lastName,salary,department)
        {
            this.Employees = employees;
        }

        public List<RegularEmployee> Employees { get; set; }
    }
}
