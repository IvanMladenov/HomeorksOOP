namespace CompanyHierarchy.Humans
{
    abstract class RegularEmployee:Employee
    {
        public RegularEmployee(string id, string firstName, string lastName, decimal salary, string department)
            :base(id,firstName,lastName,salary,department)
        {
        }
    }
}
