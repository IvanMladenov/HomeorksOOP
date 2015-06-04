using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sqrt
{
    class Sqrt
    {
        static void Main(string[] args)
        {
            try
            {
                int number = int.Parse(Console.ReadLine());

                if(number<0)
                {
                    throw new FormatException();
                }

                double sqrt = Math.Sqrt(number);

                Console.WriteLine(sqrt);
            }
            catch (FormatException)
            {
                Console.WriteLine("Iput must be an integer and greather than zero!");
            }
            finally
            {
                Console.WriteLine("Good bye!");
            }
        }
    }
}
