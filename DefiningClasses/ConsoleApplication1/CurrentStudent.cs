using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class CurrentStudent:Student
    {
        private string courseName;

        public CurrentStudent(string firstName, string lastName, int age, long studentNumber, double avgGrade, string courseName):
            base(firstName,lastName,age,studentNumber,avgGrade)
        {
            this.CourseName = courseName;       
        }

        public string CourseName 
        {
            get { return this.courseName; }
            set
            {
                if(string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Course name must be at least 1 simbol.");
                }
                this.courseName=value;
            }
        }
    }
}
