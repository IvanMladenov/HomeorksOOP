using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persons
{
    class Persons
    {
        static void Main()
        {
            Person current = new Person("Peshto",32);//email moje da se dobavi 

            Console.WriteLine(current);
        }
    }

    class Person
    {

        private string name;

        private int age;

        private string email;

        public Person(string name, int age, string email)
        {
            this.Name = name;
            this.Age = age;
            this.EMail = email;
        }
        public Person(string name, int age):this(name,age,null)
        {
            this.Name = name;
            this.Age = age;
        }
       

        public string Name 
        { 
            get
            {
                return this.name;
            } 
            
            set
            {
              
                if (value == null || value.Length < 1)
                {
                    throw new ArgumentException("Name must contains at least one simbol");
                }
                this.name = value;

            }
                
        }

        public int Age 
        {
            get { return this.age; }
            set 
            {
                this.age=value;
                if(value>100||value<1)
                {
                    throw new ArgumentException("Age must be between 1 and 101");
                }
            }
        }

        public string EMail
        {
            get
            { 
                return this.email; 
            }
            set 
            {
                this.email = value;
                if(value != null&&!value.Contains("@"))
                {
                    throw new ArgumentException("Not valid email!");
                }
            }
        }

        public override string ToString()
        {
            return string.Format("Name: {0}, Age: {1}, Email: {2}",this.Name,this.Age,this.EMail??"No data");
        }
    }
}
