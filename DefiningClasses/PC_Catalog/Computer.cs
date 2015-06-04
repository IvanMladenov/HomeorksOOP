using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace PC_Catalog
{
    class Computer
    {
        private string name;
        private List<Components> components;
        private decimal price;
        //Ctor
        public Computer(string name, List<Components>components)
        {
            this.Name = name;
            this.Components = components;
        }
        //Property
        private string Name
        {
            get { return this.name; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("String cannot be empty.");
                }
                this.name = value;
            }
        }

        private List<Components>Components
        {
            get { return this.components; }
            set
            {
                if(value.Count<=0)
                {
                    throw new IndexOutOfRangeException("Computer must contains at least one component");
                }
                this.components = value;
            }
        }

        public decimal Price
        {
            get { return CalcPrice(this); }
        }

        public static decimal CalcPrice(Computer computer)
        {
            var components = computer.Components;
            decimal price = 0;

            foreach(var item in components)
            {
                price += item.Price;
            }
            return price;
        }

        public override string ToString()
        {
            Thread.CurrentThread.CurrentCulture = new CultureInfo("bg");

            StringBuilder forPrint = new StringBuilder();

            forPrint.AppendLine(name+"\n");
            decimal computerPrice=0;
            foreach(var item in components)
            {
                forPrint.AppendLine(item.Name+" - "+item.Price.ToString("C",CultureInfo.CurrentCulture));
                computerPrice+=item.Price;
            }
            forPrint.AppendLine("\nTotal Price:" + " " + computerPrice.ToString("C",CultureInfo.CurrentCulture));
            forPrint.AppendLine(new string('-', 20));

            return forPrint.ToString();
        }
    
    }
}
