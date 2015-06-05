using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class GraduateStudent:Student
    {
        public GraduateStudent(string firstName, string lastName, int age, long studentNumber, double avgGrade)
            :base(firstName,lastName,age,studentNumber,avgGrade)
        {
                
        }
    }
}
