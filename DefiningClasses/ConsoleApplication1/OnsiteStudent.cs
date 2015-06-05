using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    
    class OnsiteStudent:CurrentStudent
    {
        private int numberOfVisits;

         public OnsiteStudent(string firstName, string lastName, int age, long studentNumber, double avgGrade, string courseName, int numberOfVisits)
            :base(firstName,lastName,age,studentNumber,avgGrade,courseName)
        {
            this.NumberOfVisits = numberOfVisits;
        }

         public int NumberOfVisits 
         {
             get { return this.numberOfVisits; }
             set
             {
                 if(value<0)
                 {
                     throw new ArgumentOutOfRangeException("Number of visits cant be less than zero;");
                 }
                 this.numberOfVisits = value;
             }
         }
    }
}
