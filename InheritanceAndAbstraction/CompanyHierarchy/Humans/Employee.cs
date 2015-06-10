namespace CompanyHierarchy.Humans
{
    class Employee : Pearson
    {
        private readonly string[] depnts=new string[]{"Production", "Accounting", "Sales", "Marketing"};

        private decimal salary;
        private string department;

        public Employee(string id, string firstName, string lastName, decimal salary, string department)
            : base(id, firstName, lastName)
        {
            this.Salary = salary;
            this.Department = department;
        }

        public string Department 
        { 
            get { return this.department; } 
            set { this.department = value; } 
        }

        public decimal Salary 
        {
            get { return this.salary; }
            set { this.salary = value; }
        }


    }
}
