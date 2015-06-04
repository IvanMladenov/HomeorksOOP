using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PC_Catalog
{
    class Components
    {
        private string name;
        private decimal price;

        public Components(string name, decimal price, string details):this(name,price)
        {
            this.Details = details;
        }

        public Components(string name, decimal price)
        {
            this.Price = price;
            this.Name = name;
        }

        public string Name
        {
            get { return this.name; }
            set
            {
                if(string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("String cannot be empty.");
                }
                this.name = value;
            }
        }
        
        public decimal Price
        {
            get { return this.price; }
            set
            {
                if(value<0)
                {
                    throw new ArgumentOutOfRangeException("Prise must be greather than 0");
                }
                this.price = value;
            }
        }

        public string Details { get; set; }

        //public override string ToString()
        //{
        //    return string.Format(name+" - "+price);
        //}
    }
}
