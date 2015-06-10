using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P2_Animals
{
    abstract class Animal:ISoundProducible
    {
        private string name;
        private int age;
        //private string gender;

        public Animal(string name, int age, Gender gender)
        {
            this.Name = name;
            this.Age = age;
            this.Gender = gender;
        }

        public string Name 
        {
            get { return this.name; }
            set
            {
                if(string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("Name cant be null, empty or whitespace");
                }
                this.name = value;
            }
        }
        public int Age 
        {
            get { return this.age; }
            set
            {
                if(value<0||value>30)
                {
                    throw new ArgumentOutOfRangeException("Age must be between [0...30].");
                }
                this.age = value;
            }
        }

        public Gender Gender { get; set; }
       

        public override string ToString()
        {
            return string.Format("{0}\n{1}\n{2}",this.Name,this.Age,this.Gender);
        }

        public abstract void ProduceSound();
    }
}
