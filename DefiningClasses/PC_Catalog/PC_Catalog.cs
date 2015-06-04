using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PC_Catalog
{
    class PC_Catalog
    {
        static void Main(string[] args)
        {
           
            
            Components motherboard = new Components("motherboard", 25.60m);
            Components ram = new Components("ram", 13.75m);
            Components powerSuply = new Components("power", 20.5m);
            Components hdd = new Components("hdd", 37.60m);
            Components videocard = new Components("videocard", 93.75m);
            Components cdROM = new Components("cd", 5.5m);
            List<Components> components = new List<Components>()
                {
                    motherboard,
                    ram,
                    powerSuply
                };
            var sortedOne = components.OrderBy(x => x.Price).ToList();
           
            List<Components> componentsTwo = new List<Components>()
                {
                    motherboard,
                    hdd,
                    powerSuply,
                    cdROM
                };
            var sortedTwo=componentsTwo.OrderBy(x => x.Price).ToList();

            List<Components> componentsThree = new List<Components>()
            {
                motherboard,
                ram,
                powerSuply,
                hdd,
                videocard,
                cdROM              
            };
            var sortedThree = componentsThree.OrderBy(x => x.Price).ToList();


            Computer dell = new Computer("Dell",sortedOne);
            Computer sony = new Computer("Sony", sortedTwo);
            Computer toshiba = new Computer("Toshiba", sortedThree);
            List<Computer> computers = new List<Computer>()
            {
                toshiba,dell, sony
            };
           
            var sorted = computers.OrderBy(x =>x.Price).ToList();

            foreach (var item in sorted)
            {
                Console.WriteLine(item);
            }
            
        }
    }
}
