using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Student:Pearson
    {
        private long studentNumber;
        private double avgGrade;

        public Student(string firstName, string lastName, int age, long studentNumber, double avgGrade):
            base(firstName,lastName,age)
        {
            this.StudentNumber = studentNumber;
            this.AvgGrade = avgGrade;
        }

        public long StudentNumber
        {
            get { return this.studentNumber; }
            set
            {
                if(value<0)
                {
                    throw new ArgumentOutOfRangeException("Student number can't be less than 0.");
                }
                this.studentNumber = value;
            }
        }

        public double AvgGrade
        {
            get { return this.avgGrade; }
            set
            {
                if(value<2||value>6)
                {
                    throw new ArgumentOutOfRangeException("Avg grade is in range [2...6");
                }
                this.avgGrade = value;
            }
        }
    }
}
