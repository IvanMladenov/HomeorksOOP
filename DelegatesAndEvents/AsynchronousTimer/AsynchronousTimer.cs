using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsynchronousTimer
{

    class AsynchronousTimer
    {
        private static int numberOfExecutions = 1;

        static void Main()
        {
            AsyncTymer timer = new AsyncTymer(5, 3000, Print);
            timer.Start();
        }
        private static void Print()
        {
            Console.WriteLine("Hello - Number: {0}",numberOfExecutions++);
        }

    }
}
