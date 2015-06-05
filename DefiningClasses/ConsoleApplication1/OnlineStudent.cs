using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class OnlineStudent:CurrentStudent
    {
        public OnlineStudent(string firstName, string lastName, int age, long studentNumber, double avgGrade, string courseName)
            :base(firstName,lastName,age,studentNumber,avgGrade,courseName)
        {
        }
    }
}
