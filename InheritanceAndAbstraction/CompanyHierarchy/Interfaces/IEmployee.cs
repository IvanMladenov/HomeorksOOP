using CompanyHierarchy.Humans;

namespace CompanyHierarchy.Interfaces
{
    interface IEmployee:IHuman
    {

        decimal Salary { get; }
    
    }
}
