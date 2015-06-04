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
            int lastNumber = 0;
            for (int i = 0; i < 10; i++)                
            {
                try
                {
                    lastNumber=ReadNumber(1,100,lastNumber);
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
                catch(ArgumentOutOfRangeException)
                {
                    Console.WriteLine("The number must be greather than previous number.");
                }
                
            }
           
        }

        static int ReadNumber(int start, int end,int lastNumber)
        {
            int number = int.Parse(Console.ReadLine());

            if(number<start||number>end)
            {
                throw new IndexOutOfRangeException();
            }
            else if(number<=lastNumber)
            {
                throw new ArgumentOutOfRangeException();
            }
            else
            {
                lastNumber = number;
            }
            return lastNumber;
        }
    }
}
