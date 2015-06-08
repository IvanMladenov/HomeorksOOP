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
        static void Main()
        {
            BitArray arr = new BitArray(8);
            
            //Test for change some bits
            arr[7] = 1;
            arr[0] = 1;
            Console.WriteLine(arr);
            //test maximum lenght - test failed for realy big sequences
            BitArray arr1 = new BitArray(100000);

            arr1[999] = 1;//this test works
            Console.WriteLine(arr1);


        }
    }
}
