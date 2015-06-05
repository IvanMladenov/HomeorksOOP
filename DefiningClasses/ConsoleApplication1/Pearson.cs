using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Pearson
    {
        private string firstName;
        private string lastName;
        private int age;

        public Pearson(string firstName, string lastName, int age)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
        }

        public string FirstName
        {
            get {return this.firstName ;}
            set
            {
                if(string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("First name must be at least 1 simbol.");
                }
                this.firstName = value;
            }
        }

        public string LastName
        {
            get { return this.lastName;}
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Last name must be at least 1 simbol.");
                }
                this.lastName = value;
            }
            
        }

        public int Age
        {
            get { return this.age;}
            set
            {
                if(value<1||value>120)
                {
                    throw new IndexOutOfRangeException("Age can be in range [1....120]");
                }
                this.age = value;
            }
        }
    }
}
