using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class SULST
    {
        static void Main(string[] args)
        {
            //Take the data from PhillKolev Homework :-)

            Trainer regularTrainer = new Trainer("Gogo", "Strogiya", 60);
            JuniorTrainer juniorTrainer = new JuniorTrainer("Asistent", "Pomagachev", 24);
            SeniorTrainer seniorTrainer = new SeniorTrainer("Golemec", "Shisharkov", 42);
            regularTrainer.CreateCourse("OOP");
            juniorTrainer.CreateCourse("QPC");
            seniorTrainer.CreateCourse("ABC");
            seniorTrainer.DeleteCourse("DEF");
            Console.WriteLine();

            DropoutStudent applicant = new DropoutStudent("Pesho","Peshev",31,1234567,2.50,"Ne mu vijdam ochite");
            applicant.Reapply();
            Console.WriteLine();

            var people = new List<Pearson>
        {
            new Pearson("Georgi", "Georgiev", 20),
            new Trainer("Ivan", "Ivanov", 28),
            new JuniorTrainer("Ivan", "Ivanov Jr.", 19),
            new SeniorTrainer("Ivan", "Ivanov Sr.", 35),
            new Student("Pesho", "Peshev", 22, 1234, 5.75),
            new DropoutStudent("Misho", "Mihaylov", 25, 1234, 3.5, "Too few women on campus."),
            new GraduateStudent("Golemets", "Golemiya", 31, 1234, 5.25),
            new CurrentStudent("Stamat", "Botusharov", 23, 1234, 3.25, "OOP"),
            new OnlineStudent("Myrzeliv", "Myrzelivets", 21, 1234, 2.5, "OOP"),
            new OnsiteStudent("Svetlin", "Nakov", 34, 1234, 6, "OOP", 15),
            new CurrentStudent("Irokentij", "Portokalov", 43, 1234, 4.25, "QPC"),
            new OnlineStudent("Onufrij", "Popryckov", 63, 1234, 5.15, "QPC"),
            new OnsiteStudent("Maria", "Ivanova", 19, 1234, 5.86, "QPC", 12)
        };

            var currentStudents = people.Where(x => x is CurrentStudent).ToList().Cast<CurrentStudent>().ToList();
            var sorted = currentStudents.OrderBy(x => x.AvgGrade).ToList();

            foreach(var item in sorted)
            {
                StringBuilder currentStudent = new StringBuilder();
                currentStudent.AppendLine(item.FirstName);
                currentStudent.AppendLine(item.LastName);
                currentStudent.AppendLine(item.Age.ToString());
                currentStudent.AppendLine(item.AvgGrade.ToString());
                currentStudent.AppendLine(item.CourseName);
                currentStudent.AppendLine(item.StudentNumber.ToString());

                Console.WriteLine(currentStudent.ToString());
                Console.WriteLine();

            }
        }
    }
}
