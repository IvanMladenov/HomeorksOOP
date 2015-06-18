﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsynchronousTimer
{
    using System.Threading;

    // public delegate void ToBeCalled();

    public class AsyncTymer
    {

        public AsyncTymer(int calls, int interval, Action del)
        {
            this.Execute = del;
            this.Interval = interval;
            this.NumberOfCalls = calls;
        }

        public Action Execute { get; set; }

        public int NumberOfCalls { get; set; }

        public int Interval { get; set; }

        public void Start()
        {
            Thread sleep = new Thread(this.CallTheMethod);
            sleep.Start();
        }

        private void CallTheMethod()
        {
            for (int i = 0; i < this.NumberOfCalls; i++)
            {               
                this.Execute();
                Thread.Sleep(this.Interval);
            }
        }
    }
}
