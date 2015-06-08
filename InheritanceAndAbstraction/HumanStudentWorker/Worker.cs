using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanStudentWorker
{
    class Worker:Human
    {
        private decimal weekSalary;
        private double workHoursPerDay;

        public Worker(string firstName, string lastName,decimal weekSalary,double workHourPerDay)
            :base(firstName,lastName)
        {
            this.WeekSalary = weekSalary;
            this.WorkHoursPerDay = workHourPerDay;
        }

        public decimal WeekSalary 
        {
            get { return this.weekSalary; }
            set { this.weekSalary = value; }
        }

        public double WorkHoursPerDay 
        {
            get { return this.workHoursPerDay; }
            set { this.workHoursPerDay = value; }
        }

        public decimal MoneyPerHour()
        {
            if(workHoursPerDay==0)
            {
                return 0;
            }
            decimal moneyPerHour = (decimal)(this.WeekSalary)/(decimal)(this.workHoursPerDay * 5);
            return moneyPerHour;
        }

        public override string ToString()
        {
            return base.ToString() +"\n"+weekSalary+"\n"+workHoursPerDay;
        }
    }
}
