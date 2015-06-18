namespace CostomLINQEextension
{
    using System;
    using System.Collections.Generic;

    internal class MainTest
    {
        private static void Main()
        {
            var testWhereNot = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            var oddNumbers = testWhereNot.WhereNot(x => x % 2 == 0); // Filter not even elements
            Console.WriteLine(string.Join(", ", oddNumbers));

            var students = new List<Students>
                               {
                                   new Students("Ivan", 3), 
                                   new Students("Pesho", 4), 
                                   new Students("Gosho", 6), 
                                   new Students("Minka", 3), 
                                   new Students("Iva", 5), 
                                   new Students("Zarko", 4)
                               };

            var maxGrade = students.Max(x => x.Grade); // Get Grade Props and return max grade

            Console.WriteLine(maxGrade);

            var maxName = students.Max(x => x.Name); // Get Name Props and return max name

            Console.WriteLine(maxName);
        }
    }
}