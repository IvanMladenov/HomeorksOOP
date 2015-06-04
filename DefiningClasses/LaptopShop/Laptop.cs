using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaptopShop
{
    class Laptop
    {
        private string model;//todo
        private double price;//todo
        private string processor;//todo
        private int ram;//todo
        private string grCard;//todo
        private string hdd;//todo
        private string screen;//todo
        private Battery battery;//todo

        public Laptop(string model,double price,string processor,int ram,string grCard,string hdd,string screen,Battery battery):this(model, price)
        {
            
            this.Processor = processor;
            this.Ram = ram;
            this.GrCard = grCard;
            this.Hdd = hdd;
            this.Screen = screen;
            this.Batt = battery;
        }
        public Laptop(string model,double price)
        {
            this.model = model;
            this.price = price;
        }

        public string Model
        {
            get { return this.model; }
            set
            {
                this.model=value;
                if(string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("String cannot be null or empty!");
                }
            }
        }

        public double Price
        {
            get { return this.price; }
            set
            {
                this.price = value;
                if(value<0)
                {
                    throw new Exception("Price must be greather than 0.");
                }
            }
        }

        public string Processor
        {
            get { return this.processor; }
            set
            {
                this.processor = value;
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("String cannot be null or empty!");
                }
            }
        }

        public int Ram
        {
            get { return this.ram; }
            set
            {
                if(value<0||value==null)
                {
                    throw new ArgumentException("Value must be greather than zero!");
                }
                this.ram = value;
            }
        }

        public string GrCard
        {
            get { return this.grCard; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("String cannot be null or empty!");
                }
                this.grCard = value;
            }
        }

        public string Hdd
        {
            get { return this.hdd; }
            set 
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("String cannot be null or empty!");
                }
                this.hdd=value;
            }
        }

        public string Screen
        {
            get { return this.screen; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("String cannot be null or empty!");
                }
                this.screen = value;
            }
        }

        public Battery Batt { get; set; }

        public override string ToString()
        {
            return string.Format("{0}\n{1}\n{2}\n{3}\n{4}\n{5}\n{6}\n{7}",model,price,processor,ram,grCard,hdd,screen,battery);
        }
       

    }
}
