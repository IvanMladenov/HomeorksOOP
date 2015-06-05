using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Trainer:Pearson
    {
        public Trainer(string firstName, string lastName, int age)
            : base(firstName,lastName,age)
        {
                
        }

        public void CreateCourse(string courseName)
        {
            Console.WriteLine("Create new course: {0}", courseName);
        }
    }
}
