namespace StudentClass
{
    using System;

    internal class StudentClass
    {
        private static void Main()
        {
            Student student = new Student("Ivan", 35);
            student.PropertyChanged += PrintTheChange;
            student.Name = "Pesho";
            student.Age = 40;
        }

        private static void PrintTheChange(object sender, PropertyChangedEventArgs args)
        {
            Console.WriteLine(args);
        }
    }
}