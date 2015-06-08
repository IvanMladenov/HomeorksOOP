using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanStudentWorker
{
    class HumanStudentWorker
    {
        static void Main(string[] args)
        {
            ///UNCOMMENT PRINT AREA TO TEST.

            List<Student> students = new List<Student>()
            {
                new Student("First", "Student", "bbbbb"),
                new Student("Second", "Student", "aaaaa"),
                new Student("Third", "Student", "ccccc"),
                new Student("Fourth", "Student", "ddddd"),
                new Student("Fifth", "Student", "eeeee"),
                new Student("Sixth", "Student", "zzzzz"),
                new Student("Seventh", "Student", "ggggg"),
                new Student("Eight", "Student", "hhhhh"),
                new Student("Ninth", "Student", "iiiii"),
                new Student("Tenth", "Student", "jjjjj")

            };
            var sorted = students.OrderBy(x => x.FacultyNumber);

            //foreach (var item in sorted)
            //{
            //    Console.WriteLine(item);
            //}

            List<Worker> workers = new List<Worker>()
            {
                new Worker("First", "Worker", 23m, 16),
                new Worker("Second", "Worker", 55.99m, 24),
                new Worker("Third", "Worker", 0.1m, 0),
                new Worker("Fourth", "Worker", 100000m, 1),
                new Worker("Fifth", "Worker", 123.12m, 12),
                new Worker("Sixth", "Worker", 0.1m, 15),
                new Worker("Seventh", "Worker", 2134, 2.5),
                new Worker("Eighth", "Worker", 32, 11.5),
                new Worker("Ninth", "Worker", 100, 10),
                new Worker("Tenth", "Worker", 50, 8)
            };
            var sortedWorkers = workers.OrderByDescending(x => x.MoneyPerHour());


            //foreach (var item in sortedWorkers)
            //{
            //    Console.WriteLine(item);
            //}

            List<Human> merged = new List<Human>(20);
            merged.AddRange(students);
            merged.AddRange(workers);

            var sortedHumans = merged.OrderBy(x => x.FirstName).ThenBy(x => x.LastName);

            //foreach (var item in sortedHumans)
            //{
            //    Console.WriteLine(item);
            //}
        }
    }
}
