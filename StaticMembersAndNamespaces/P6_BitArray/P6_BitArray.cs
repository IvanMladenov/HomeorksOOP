using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace P6_BitArray
{
    class P6_BitArray
    {
        static void Main(string[] args)
        {
            BitArray arr = new BitArray(3);
            
            //Test for change some bits
            arr[1] = 1;
            arr[0] = 1;
            Console.WriteLine(arr);
            //test maximum lenght - test failed 
            BitArray arr1 = new BitArray(100000);

            arr1[999] = 1;
            Console.WriteLine(arr1);
            //Console.WriteLine(BigInteger.ca)

        }
    }
}
