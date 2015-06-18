namespace StudentClass
{
    public delegate void PropertyChangedEventHandler(Student student, PropertyChangedEventArgs args);

    public class Student
    {
        private int age;

        private string name;

        public PropertyChangedEventHandler PropertyChanged;

        public Student(string name, int age)
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
                if (this.PropertyChanged != null)
                {
                    this.PropertyChanged(this, new PropertyChangedEventArgs("Name", this.Name, value));
                }

                this.name = value;
            }
        }

        public int Age
        {
            get
            {
                return this.age;
            }

            set
            {
                if (this.PropertyChanged != null)
                {
                    this.PropertyChanged(
                        this, 
                        new PropertyChangedEventArgs("Age", this.Age.ToString(), value.ToString()));
                }

                this.age = value;
            }
        }
    }
}