using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class DropoutStudent:Student
    {
        private string dropOutReason;

        public DropoutStudent(string firstName, string lastName, int age, long studentNumber, double avgGrade, string dropOutReason)
            :base(firstName,lastName,age,studentNumber,avgGrade)
        {

        }

        public string DropOutReason 
        {
            get { return this.dropOutReason; }
            set
            {
                if(string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("The reason must be at least one simbol.");
                }
                this.dropOutReason=value;
            }
        }

        public void Reapply()
        {
            Console.WriteLine("{0}\n{1}\n{2}\n{3}\n{4}\n{5}", FirstName, LastName, Age, StudentNumber, AvgGrade, dropOutReason);
        }

        //public override string ToString()
        //{
        //    return string.Format("{0}\n{1}\n{2}\n{3}\n{4}\n{5}",FirstName,LastName,Age,StudentNumber,AvgGrade,dropOutReason);
        //}
    }
}
