namespace CostomLINQEextension
{
    public class Students
    {
        public Students(string name, int grade)
        {
            this.Grade = grade;
            this.Name = name;
        }

        public string Name { get; set; }

        public int Grade { get; set; }
    }
}