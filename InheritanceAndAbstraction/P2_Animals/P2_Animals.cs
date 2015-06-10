using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P2_Animals
{
    class P2_Animals
    {
        static void Main(string[] args)
        {
            Kitten kitti = new Kitten("Mery", 5);
            Cat cat = new Cat("Penka", 10, Gender.Female);
            Dog dog = new Dog("Gosho", 11, Gender.Male);
            Frog frog = new Frog("Jaburana", 2, Gender.Female);
            Tomcat tomy = new Tomcat("Silvester", 2);
            Animal jabcho = new Frog("Jabcho", 1, Gender.Male);
            Animal barky = new Dog("Barky", 7, Gender.Male);
            Animal katy = new Kitten("katy", 5);
            Animal doncho = new Tomcat("Doncho", 1);


            cat.ProduceSound();
            doncho.ProduceSound();
            kitti.ProduceSound();
            frog.ProduceSound();
            barky.ProduceSound();

            List<Animal> all = new List<Animal>()
            {
                kitti,
                cat,
                dog,
                frog,
                tomy,
                jabcho,
                barky,
                katy,
                doncho,
            };

            var dogsAge = all.Where(x => x is Dog).Average(x => x.Age);
            var catsAge = all.Where(x => x is Cat).Average(x => x.Age);
            var frogAge = all.Where(x => x is Frog).Average(x => x.Age);
            var kittenAge = all.Where(x => x is Kitten).Average(x => x.Age);
            var tomcatAge = all.Where(x => x is Tomcat).Average(x => x.Age);

            Console.WriteLine("Dogs avg: {0}\nCats avg: {1}\nfrog avg: {2}\nKitten avg: {3}\nTomcat avg: {4}"
                , dogsAge, catsAge, frogAge, kittenAge, tomcatAge);
        }
    }
}
