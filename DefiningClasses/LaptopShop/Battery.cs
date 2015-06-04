using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaptopShop
{
    class Battery
    {
        private double batteryLive;
        private string batteryType;

        public Battery(double batteryLive, string batteryType):this()
        {
            this.Live = batteryLive;
            this.Type = batteryType;
        }
        public Battery()
        { }

        public string Type
        {
            get { return this.batteryType; }
            set 
            {
                this.batteryType = value;
                if(string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Type cannot be null or empty!");
                }              
            }
        }
        public double Live
        {
            get { return this.batteryLive; }
            set 
            {
                this.batteryLive=value;
                if(value<=0)
                {
                    throw new ArgumentException("Battery live must be greather than 0.");
                }
            }
        }
        public override string ToString()
        {
            return string.Format("{0}\n{1} hours",this.Type,this.Live);
        }
    }
}
