using System.Collections.Generic;
using CompanyHierarchy.Props;

namespace CompanyHierarchy.Humans
{
    class Developer:RegularEmployee
    {
        public Developer(string id, string firstName, string lastName, decimal salary, string department)
            :base(id,firstName,lastName,salary,department)
        {
            this.Projects = new List<Projects>();
        }

        public List<Projects> Projects { get; set; }

       
    }
}
