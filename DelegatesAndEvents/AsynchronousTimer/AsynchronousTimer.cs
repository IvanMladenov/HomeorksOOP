namespace AsynchronousTimer
{
    using System;

    internal class AsynchronousTimer
    {
        private static int numberOfExecutions = 1;

        private static void Main()
        {
            AsyncTymer timer = new AsyncTymer(5, 3000, Print);
            timer.Start();
        }

        private static void Print()
        {
            Console.WriteLine("Hello - Number: {0}", numberOfExecutions++);
        }
    }
}