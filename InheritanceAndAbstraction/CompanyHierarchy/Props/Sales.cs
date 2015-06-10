using System;

namespace CompanyHierarchy.Props
{
    class Sales
    {
        public Sales(string saleName,DateTime date,decimal price)
        {
            this.SaleName = saleName;
            this.Date = date;
            this.Price = price;
        }

        public string SaleName { get; set; }

        public DateTime Date { get; set; }

        public decimal Price { get; set; }
    }
}
