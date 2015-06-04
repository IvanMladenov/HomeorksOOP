using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnterNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 10; i++)
            {
                try
                {
                    ReadNumber(1, 100);
                }
                catch(FormatException)
                {
                    Console.WriteLine("The number must be an integer!");
                    i--;
                }
                catch(IndexOutOfRangeException)
                {
                    Console.WriteLine("The number must be in range [1...100]");
                    i--;
                }
                
            }
           
        }

        static void ReadNumber(int start, int end)
        {
            int number = int.Parse(Console.ReadLine());

            if(number<start||number>end)
            {
                throw new IndexOutOfRangeException();
            }
        }
    }
}
