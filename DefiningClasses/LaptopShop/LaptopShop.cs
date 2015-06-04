using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaptopShop
{
    class LaptopShop
    {
        static void Main()
        {
            Battery blankBatt = new Battery();//blank battery

            Battery batt=new Battery(4.5,"Li-Ion, 4-cells, 2550 mAh");//battery with arguments

            Laptop laptopMandatory=new Laptop("Sony", 1222.30);

            Laptop laptop = new Laptop//laptop with arguments
                (
                    "Lenovo",

                    1577.00,

                    "Intel Core i5-4210U (2-core, 1.70 - 2.70 GHz, 3MB cache)",
                    8,

                    "Intel HD Graphics 4400",

                    "128GB SSD",

                    "13.3\" (33.78 cm) – 3200 x 1800 (QHD+), IPS sensor display",

                    batt
                );

            Laptop mandatoryLaptop = new Laptop("Lenovo", 1788.25);

            Console.WriteLine("{0}\n\n",batt);
            Console.WriteLine("{0}\n\n", laptopMandatory);
            Console.WriteLine(laptop);


           
        }

        
    }
}
